using System;
using Unity.VisualScripting;
using UnityEngine;



    class CrazyBox : MonoBehaviour, IIdentifiable
    {
        public void Action(Player player)
        {
            Debug.Log("CrazyBox");
        }

    }
