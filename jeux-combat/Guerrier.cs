using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeux_combat
{
    class Guerrier
    {
		/**************** CLASSE GUERRIER ******************/
			//ses caractèristique
		private string nom;
		private int attaque;
		private int defense;
		private int sante;

		//encapsulations des données
		public string Name
		{
			get { return this.nom ;}
			set { this.nom = value;}
		}
		public int Attaque
		{
			get { return this.attaque ;}
			set { this.attaque = value;}
		}
		public int Defense
		{
			get { return this.defense ;}
			set { this.defense = value;}
		}
		public int Sante
		{
			get { return this.sante; }
			set { this.sante = value; }
		}
		//constructeurs
		public Guerrier(string guerrierNom, int guerrierAttaque, int guerrierDefense, int guerrierSante)
		{
			this.nom = guerrierNom;
			this.attaque = guerrierAttaque;
			this.defense = guerrierDefense;
			this.sante = guerrierSante;

		}

		//méthode pour lancer l'attaque
		public void LancerAttaque(Guerrier nomCible){
			if (nomCible.sante > 0)
			{
				nomCible.Sante -= this.Attaque;
					if (nomCible.sante <= 0)
				{
					Console.WriteLine(nomCible.nom + " est mort(e) !");
				}
			}

			Affichage();
			nomCible.Affichage();
		}

		public void LancerAttaqueAvecDefense (Guerrier nomCible)
        {
			if (this.Attaque > nomCible.Defense)
            {
				nomCible.Sante -= Attaque;
            }
			else if (this.Attaque < nomCible.Defense)
            {
				this.Sante = Attaque - nomCible.Defense;
				if (nomCible.sante < 0)
				{
					Console.WriteLine(this.nom + " est mort(e) !");
				}
			}
			Affichage();
			nomCible.Affichage();
        }

		public void Affichage()
        {
			Console.WriteLine("nom : " + this.nom + " " + this.attaque + " " + this.defense + " " + this.sante);
        }


	}
}
