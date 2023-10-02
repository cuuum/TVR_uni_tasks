using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buton : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject[] gameObjects;

    public void onClick()
    {
        foreach(var i in gameObjects)
        {
            if (i.GetComponent<Figure>())
            {
                i.GetComponent<Figure>().ChangeAct();
            }
        }
    }
}
