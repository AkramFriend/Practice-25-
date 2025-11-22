using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public void DestroyHero()
    {
        Destroy(gameObject);
    }
}
