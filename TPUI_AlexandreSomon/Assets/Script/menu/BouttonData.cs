using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ButtonData")]
public class BouttonData : ScriptableObject
{
    //A priori la liste se crée dans unity, on la change directement depuis unity (taille et contenu)
    //J'ai essayé de la créer ici avec du contenu, mais ça à pas l'air de fonctionner (jai pas cherché trop longtemps non plus)   
    public List<string> text;
}
