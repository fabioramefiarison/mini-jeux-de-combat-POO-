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
		private int mana;

		//constructeurs
		public Guerrier(string guerrierNom, int guerrierAttaque, int guerrierDefense, int guerrierSante)
		{
			this.nom = guerrierNom;
			this.attaque = guerrierAttaque;
			this.defense = guerrierDefense;
			this.sante = guerrierSante;

		}

		//constructeurs avec propriété mana
		public Guerrier(string guerrierNom, int guerrierAttaque, int guerrierDefense, int guerrierSante, int guerrierMana = 100)
		{
			this.nom = guerrierNom;
			this.attaque = guerrierAttaque;
			this.defense = guerrierDefense;
			this.sante = guerrierSante;
			this.mana = guerrierMana;
		}

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

		public int Mana
		{
			get { return this.mana; }
			set { this.mana = value; }
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
				if (this.Sante < 0)
				{
					Console.WriteLine(this.nom + " est mort(e) !");
				}
			}
			else
            {
				Console.WriteLine("égalité entre eux !");
            }
        }

		//méthode Affichages
		public void Affichage()
        {
			Console.WriteLine("Personnage  " + this.nom + " : " + " Attaque(" + this.attaque + ") Défense(" + this.defense + ") " + "Santé(" + this.sante + ")");
        }

		public void ActiveSoin ()
        {
			this.sante += 10;
			this.mana -= 10;
			if (this.mana == 0)
            {
				Console.WriteLine("Mana ne peut pas se lancer !");
            }
        }
	}
}
