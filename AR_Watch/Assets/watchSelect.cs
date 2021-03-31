using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class watchSelect : MonoBehaviour
{
    //Declaring variables inorder to assign them in inside UNITY 

    public GameObject watchModel1;  // watch models
    public GameObject watchModel2;
    public GameObject watchModel3;

    public GameObject w1window; //watch windows 
    public GameObject w2window;
    public GameObject w3window;

    Animation w1windowAnimation; // respective animations
    Animation w2windowAnimation;
    Animation w3windowAnimation;


    // Start is called before the first frame update
    void Start()
    {
        w1windowAnimation = w1window.GetComponent<Animation>();
        w2windowAnimation = w2window.GetComponent<Animation>();
        w3windowAnimation = w3window.GetComponent<Animation>();
    }

    // function for the buttons to make it interactive
    // FIRST - Bring the watch model into the scene
    //SECOND - Bring the deatils page with the animations enabled 

    public void WatchOneButtonClicked(){  // watch 1

        watchModel1.SetActive(true);
        watchModel2.SetActive(false);
        watchModel3.SetActive(false);

        w1windowAnimation["w1animation"].speed = 1;
        w1windowAnimation.Play();

    }

    public void WatchTwoButtonClicked(){    // watch 2

        watchModel1.SetActive(false);
        watchModel2.SetActive(true);
        watchModel3.SetActive(false);

        w2windowAnimation["w2animation"].speed = 1;
        w2windowAnimation.Play();
        
    }

    public void WatchThreeButtonClicked(){  // watch 3

        watchModel1.SetActive(false);
        watchModel2.SetActive(false);
        watchModel3.SetActive(true);

        w3windowAnimation["w3animation"].speed = 1;
        w3windowAnimation.Play();
        
    }

    public void CloseButtonCLicked(){      // CLOSE OPERATION

    string buttonName = EventSystem.current.currentSelectedGameObject.name;

    if(buttonName == "w1Close"){

        // to close the watch 1 window
        w1windowAnimation["w1animation"].speed = -1;
        w1windowAnimation["w1animation"].time = w1windowAnimation["w1animation"].length;
        w1windowAnimation.Play();        

    }
    else if(buttonName == "w2Close"){

        w2windowAnimation["w2animation"].speed = -1;
        w2windowAnimation["w2animation"].time = w2windowAnimation["w2animation"].length;
        w2windowAnimation.Play();

    }
    else if(buttonName == "w3Close"){

        w3windowAnimation["w3animation"].speed = -1;
        w3windowAnimation["w3animation"].time = w3windowAnimation["w3animation"].length;
        w3windowAnimation.Play();

    }

    }
    
    
}
