using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDamage : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {

            BasicEnemy target = other.gameObject.GetComponent<BasicEnemy>();
            target.curHealth -= 3;
            target.healthbar.UpdateHealt((float)target.curHealth/(float)target.maxHealth);





        }
    }
}
