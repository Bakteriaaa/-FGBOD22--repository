using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class EnableBlood : MonoBehaviour
{
    public ParticleSystem blood;
    public ParticleSystem blooda;
    public ParticleSystem bloodc;


    void OnCollisionEnter(Collision other)
   {
       Debug.Log(other.gameObject.tag);
       if (other.gameObject.tag== "Player")
       {
           blood.Play();
           blooda.Play();
           bloodc.Play();
           
               
       }
     
   }
}
