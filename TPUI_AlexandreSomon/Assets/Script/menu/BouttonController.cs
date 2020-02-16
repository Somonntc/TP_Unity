using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class BouttonController : MonoBehaviour
{
    [SerializeField] private Image myImage = default;
    private bool isToggled = true;
    private int coef;

    public void OnClick(){
        SceneManager.LoadScene("Map1");
    }

    public void ButtonAction(){
        isToggled = !isToggled;
        if(isToggled){
            coef = 0;
        }else{
            coef = 1;
        }
        Debug.Log(myImage.rectTransform.rotation.y + 180*coef);
        myImage.rectTransform.rotation = Quaternion.Euler(0,
                                                          180f*coef,
                                                          0);
    }
}
