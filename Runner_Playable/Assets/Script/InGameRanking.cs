using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameRanking : MonoBehaviour
{
    public Text[] namesTxt;
    public string a, b, c, d, e, f, g, h, j, k, l;
    
    void Update()
    {
        namesTxt[0].text = a;
        namesTxt[1].text = b;
        namesTxt[2].text = c;
        namesTxt[3].text = d;
        namesTxt[4].text = e;
        namesTxt[5].text = f;
        namesTxt[6].text = g;
        namesTxt[7].text = h;
        namesTxt[8].text = j;
        namesTxt[9].text = k;
        namesTxt[10].text = l;
    }
}
