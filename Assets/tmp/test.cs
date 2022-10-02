// using System.Diagnostics.Contracts;
// using System.ComponentModel;
// using System.Collections.Generic;
// class inventaire {
//     //propriétés
//     private List<Objet> objet; //par defaut privé


//         //Methodes
//         //void désigne ce que ma fonction renvoit, ici rien
//     void Trie() {}

// }
// class Objet {
//     private string nom;
//     private int quantite;

// // pour forcer a définir tout nos objets
// //constructeur
//     public Objet(int quantiteInitiale, string nomInitial){
//         quantite = quantiteInitiale;
//         nom = nomInitial;
//     }

//     private void incrémenterQuantite(){
//         quantite=quantite+1;

//     }

//     private void modifierNom (string nouveauNom){
//         nom= nouveauNom;
//     }
// }

// class Arme : Objet {
//     private int pointsDegats; 

//     public Arme( int quantiteInitiale, string nomInitial, int pointsDegatsInitial) : base (quantiteInitiale, nomInitial) {
//         //base renvoit a objet
//         pointsDegats = pointsDegatsInitial ;




//     }


// }

// class Main{

//     private void main(){
//         //exemples d'assignation avec objets
//         Inventaire inventaire = new Inventaire();
//         inventaire.objets = new List<Objet>();

//         Objet objet1 = new Objet();
//         objet1.name = "Potion";
//         objet1.quantite = 6;

//         Objet objet2 = new Objet();
//         objet1.name = "Bouclier";
//         objet1.quantite = 1;

//         inventaire.objet.Add(objet1);
//         inventaire.objet.Add(objet2); // on ajoute à l'inventaire apres avoir définit les objets

//     }
// }