using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject endplate;
    public GameObject gameGUI;
    public GameObject endMenuUI;
    public GameObject mainUI;
    public GameObject player;
    public GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        endMenuUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(endplate.GetComponent<DockingCheck>().docked == true){
            endMenuUI.SetActive(true);
            gameGUI.SetActive(false);
            Cursor.visible = true;
            mainUI.GetComponent<PauseMenu>().enabled = false;
            player.GetComponent<movement2>().enabled = false;
            camera.GetComponent<orbit>().enabled = false;
        }
    }
}
