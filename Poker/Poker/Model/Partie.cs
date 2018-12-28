using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Poker.Model
{
    public class Partie
    {
        [XmlIgnore]
        private String id;
        [XmlIgnore]
        private List<Joueur> liste_Joueur;
        private int argent_depart;
        [XmlIgnore]
        private PaquetCartes paquet_cartes;
        private int pot;
        [XmlIgnore]
        private Carte[] tapis;
        private int petite_blind;
        private int grande_blind;

        public Partie(String id, List<Joueur> liste_Joueur, int argent_depart, PaquetCartes paquet_cartes, int pot, Carte[] tapis, int petite_blind, int grande_blind)
        {
            this.id = id;
            this.liste_Joueur = liste_Joueur;
            this.argent_depart = argent_depart;
            this.paquet_cartes = paquet_cartes;
            this.pot = pot;
            this.tapis = tapis;
            this.petite_blind = petite_blind;
            this.grande_blind = grande_blind;
        }
        public Partie()
        {

        }

        public List<Joueur> Liste_Joueur { get => liste_Joueur; set => liste_Joueur = value; }
        public int Argent_depart { get => argent_depart; set => argent_depart = value; }
        public PaquetCartes Paquet_cartes { get => paquet_cartes; set => paquet_cartes = value; }
        public int Pot { get => pot; set => pot = value; }
        public Carte[] Tapis { get => tapis; set => tapis = value; }
        public int Petite_blind { get => petite_blind; set => petite_blind = value; }
        public int Grande_blind { get => grande_blind; set => grande_blind = value; }
        public String Id { get => id; set => id = value; }


        public void DistribuerJoueur()
        {
            for (int i = 0; i < 2; i++)
            {
                foreach (Joueur joueur in liste_Joueur)
                {
                    joueur.Main_joueur[i] = paquet_cartes.DistribuerUneCarte();
                }
            }
        }

        public void DistribuerFlop()
        {
            for (int i = 0; i < 3; i++)
            {
                Carte carte = paquet_cartes.DistribuerUneCarte();
                tapis[i] = carte;
            }
        }

        public void DistribuerRiver()
        {
            paquet_cartes.DistribuerUneCarte();
            Carte carte = paquet_cartes.DistribuerUneCarte();
            tapis[3] = carte;
        }

        public void DistribuerTapis(Partie unePartie)
        {
            paquet_cartes.DistribuerUneCarte();
            Carte carte = paquet_cartes.DistribuerUneCarte();
            tapis[4] = carte;

            Refresh_view(unePartie);
        }

        public void DonnerArgentJoueur(Partie unePartie)
        {
            for (int i = 0; i < unePartie.Liste_Joueur.Count(); i++)
            {
                unePartie.Liste_Joueur[i].Argent = unePartie.Argent_depart;
            }
            Refresh_view(unePartie);
        }

        public void SetXML()
        {
            String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//poker.xml";
            XmlSerializer writer = new XmlSerializer(typeof(Partie));
            System.IO.FileStream file = System.IO.File.Create(path);
            writer.Serialize(file, this);
            file.Close();
        }

        public Partie GetXML()
        {
            Partie partie = null;
            String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//poker.xml";
            if (File.Exists(path))
            {
                XmlSerializer reader = new XmlSerializer(typeof(Partie));
                StreamReader file = new StreamReader(path);
                partie = (Partie)reader.Deserialize(file);
                file.Close();
            }
            return partie;
        }

        public void UpdateXML() { }

        public Joueur RecupererGagnantPartie(Partie unePartie)
        {
            List<Combinaison> listeCombinaisons = new List<Combinaison>();

            for (int i = 0; i < unePartie.Liste_Joueur.Count(); i++)
            {
                listeCombinaisons.Add(Combinaison.Recuperer(unePartie, unePartie.Liste_Joueur[i]));
            }

            listeCombinaisons.Sort();

            if (listeCombinaisons[listeCombinaisons.Count() - 2].Valeur == listeCombinaisons[listeCombinaisons.Count() - 1].Valeur)
            {
                if (listeCombinaisons[listeCombinaisons.Count() - 2].ValeurMain > listeCombinaisons[listeCombinaisons.Count() - 1].ValeurMain)
                {
                    return listeCombinaisons[listeCombinaisons.Count() - 2].Joueur;
                }
                else
                {
                    return listeCombinaisons[listeCombinaisons.Count() - 1].Joueur;
                }
            }
            else
            {
                return listeCombinaisons[listeCombinaisons.Count() - 1].Joueur;
            }
        }

        public void DonnerLesRoles(Partie unePartie, int numeroJoueur)
        {
            unePartie.Liste_Joueur[numeroJoueur - 1].Role = "petite";
            unePartie.Liste_Joueur[numeroJoueur].Role = "grande";
        }

        public void CreationDesBlinds(Partie unePartie)
        {
            double temp = unePartie.Argent_depart / 100;
            temp = Math.Round(temp, 2);
            unePartie.Grande_blind = Convert.ToInt32(temp);
            temp = temp / 2;
            temp = Math.Round(temp, 2);
            unePartie.Petite_blind = Convert.ToInt32(temp);
        }

        public void MiserBlinds(Partie unePartie)
        {
            for (int i = 0; i < unePartie.Liste_Joueur.Count(); i++)
            {
                if (unePartie.Liste_Joueur[i].Role == "petite")
                {
                    unePartie.Liste_Joueur[i].Mise = unePartie.Petite_blind;
                    unePartie.Liste_Joueur[i].Argent = unePartie.Liste_Joueur[i].Argent - unePartie.Petite_blind;
                }
                else if (unePartie.Liste_Joueur[i].Role == "grande")
                {
                    unePartie.Liste_Joueur[i].Mise = unePartie.Grande_blind;
                    unePartie.Liste_Joueur[i].Argent = unePartie.Liste_Joueur[i].Argent - unePartie.Grande_blind;
                }
            }
        }

        public void Suivre(Joueur unJoueur, Joueur joueurAvant)
        {
            unJoueur.Argent = unJoueur.Argent + unJoueur.Mise - joueurAvant.Mise;
            unJoueur.Mise = joueurAvant.Mise;
        }

        public void Miser(Joueur unJoueur, int mise)
        {
            unJoueur.Statut = "miser";
            unJoueur.Argent = unJoueur.Argent + unJoueur.Mise - mise;
            unJoueur.Mise = mise;
        }

        public void Checker(Joueur unJoueur)
        {
            unJoueur.Statut = "checker";
        }

        public void SeCoucher(Joueur unJoueur, Partie unePartie)
        {
            unJoueur.Statut = "coucher";
        }

        public void AjouterAuPot(Partie unePartie)
        {
            for (int i = 0; i < unePartie.Liste_Joueur.Count(); i++)
            {
                unePartie.Pot = unePartie.Pot + unePartie.Liste_Joueur[i].Mise;
                unePartie.Liste_Joueur[i].Mise = 0;
            }
        }

        public void JoueurSuivant(Joueur unJoueur) { }

        public void FinPartie(Joueur unJoueurGagnant, Partie unePartie)
        {
            unJoueurGagnant.Argent = unePartie.Pot;
            unePartie.Pot = 0;
            unePartie.Tapis = new Carte[5];

            for (int i = 0; i < unePartie.Liste_Joueur.Count(); i++)
            {
                unePartie.Liste_Joueur[i].Mise = 0;
                unePartie.Liste_Joueur[i].Statut = "attente";
                unePartie.Liste_Joueur[i].Role = " ";
                unePartie.Liste_Joueur[i].Main_joueur = new Carte[2];
            }
        }

        public void Refresh_view(Partie unePartie)
        {
            int position_label1 = 450;
            int position_label2 = 60;
            foreach (Joueur joueur in unePartie.liste_Joueur) // Pour chaque joueur
            {
                position_label2 += 200;

                Label label_nom = new Label();
                label_nom.Text = joueur.Pseudo;
                label_nom.BackColor = Color.Salmon;
                label_nom.Top = position_label1;
                label_nom.Left = position_label2;
                label_nom.Name = joueur.Pseudo;
                Program.formPartie.Controls.Add(label_nom);
                label_nom.BringToFront();


                Label label_argent = new Label();
                label_argent.Text = "" + joueur.Argent;
                label_argent.BackColor = Color.Salmon;
                label_argent.Top = position_label1 + 20;
                label_argent.Left = position_label2;
                label_argent.Name = joueur.Pseudo;
                Program.formPartie.Controls.Add(label_argent);
                label_argent.BringToFront();


                if (joueur.Main_joueur[1] != null)
                {
                    int i = 0;
                    foreach (Carte carte in joueur.Main_joueur) // Pour chacune des cartes d'un joueur
                    {

                        Label label_carte = new Label();
                        String couleur = "";
                        switch (carte.Couleur)
                        {
                            case "Pique":
                                couleur = "♠";
                                label_carte.ForeColor = Color.Black;
                                break;
                            case "Coeur":
                                couleur = "♥";
                                label_carte.ForeColor = Color.Red;
                                break;
                            case "Trefle":
                                couleur = "♣";
                                label_carte.ForeColor = Color.Black;
                                break;
                            case "Carreau":
                                couleur = "♦";
                                label_carte.ForeColor = Color.Red;
                                break;

                            default:
                                break;
                        }

                        label_carte.Name = joueur.Pseudo + "_" + i;
                        label_carte.Text = joueur.Main_joueur[i].Valeur.ToString() + " " + couleur;
                        label_carte.Top = position_label1 -50;
                        label_carte.Left = position_label2;
                        if (i == 1) label_carte.Left = position_label2 + 5;
                        label_carte.Size = new Size(35, 40);
                        label_carte.BackColor = Color.White;
                        Program.formPartie.Controls.Add(label_carte);

                        PictureBox pb = new PictureBox();
                        pb.Name = "carte" + i + "_joueur" + joueur.Pseudo;
                        pb.Top = position_label1 - 50;
                        if (i == 1) pb.Left = position_label2;

                        pb.Size = new Size(55, 60);
                        pb.Image = Properties.Resources.Carte_vide3;
                        Program.formPartie.Controls.Add(pb);

                        i++;
                    }



                    //    //label_carte.Name = joueur.Pseudo + "_" + i;
                    //    //label_carte.Text = joueur.Main_joueur[i].Valeur.ToString() + " " + couleur;
                    //    //label_carte.Top = position_carte1 + 5;
                    //    //label_carte.Left = 5;
                    //    //if (i == 1) label_carte.Left = position_carte2 + 5;
                    //    //label_carte.Size = new Size(35, 40);
                    //    //label_carte.BackColor = Color.White;
                    //    //formPartie.Controls.Add(label_carte);

                    //    //PictureBox pb = new PictureBox();
                    //    //pb.Name = "carte" + i + "_joueur" + joueur.Pseudo;
                    //    //pb.Top = position_carte1;
                    //    //if (i == 1) pb.Left = position_carte2;

                    //    //pb.Size = new Size(55, 60);
                    //    //pb.Image = Properties.Resources.Carte_vide3;
                    //    //formPartie.Controls.Add(pb);
                    //}

                }
            }
        }
    }
}
