using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TriggerScript : MonoBehaviour
{
    public FirstPersonController_Sam firstPersonController_Sam;

    public PlayableDirector timeline;

    public bool OneTimeTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            firstPersonController_Sam.enabled = false;

            timeline.Play();

            if (OneTimeTrigger == true)
            {
                Destroy(this.gameObject);
            }

        }
    }




}
