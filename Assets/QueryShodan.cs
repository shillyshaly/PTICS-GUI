using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QueryShodan : MonoBehaviour
{
    public GameObject searchBarInput;
    
    public void Search(){
        string searchText = searchBarInput.GetComponent<TMP_InputField>().text;
        
        string url = "https://www.shodan.io/search?query=";

        Application.OpenURL(url + searchText);
    }
}
