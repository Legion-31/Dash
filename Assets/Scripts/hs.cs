
using UnityEngine;
using UnityEngine.UI;

public class hs : MonoBehaviour
{
    // Start is called before the first frame update
    public Text hss;
    

    // Update is called once per frame
    public void Update()
    {
         hss.text = PlayerPrefs.GetInt("HS").ToString("0");
    }
}
