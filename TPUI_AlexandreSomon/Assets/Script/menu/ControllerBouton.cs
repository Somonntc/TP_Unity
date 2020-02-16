using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControllerBouton : MonoBehaviour
{
    [SerializeField] private BouttonData bouttondata = default;
    [SerializeField] private TextMeshProUGUI textMeshPro;
    private int counter;

    private void Awake(){
        counter = 0;
    }
    private void Update(){
        if(counter % bouttondata.text.Count == 0){
            counter = 0;
        }
        textMeshPro.text = bouttondata.text[counter];
    }

    public void OnClick(){
        NextDialogue();
    }

    //J'ai un doute si c'est mieux de faire comme ça où directement mettre counter += 1 dans la fontion OnClick
    //J'ai fais comme ça pour que ce soit bien explicite
   private void NextDialogue(){
       counter += 1;
   }

   public void ChangeTextColor(){
       textMeshPro.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);
   }
}
