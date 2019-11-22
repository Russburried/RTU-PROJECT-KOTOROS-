using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject obj;
    public int Score_Player = 0;
    private float time = 0;
    float save_time;





    private void Update()
    {
        time++;

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Score_Player += 1;
        }
        if (Score_Player == 12)
        {
            Application.LoadLevel(Application.loadedLevel);
            if (time <= 30)
            {
                Score_Player = Score_Player * 2;
            }
            if (time>30 && time < 60)
            {
                Score_Player += Score_Player / 2;
                
            }
            
        }
        
    }
    

}

        




