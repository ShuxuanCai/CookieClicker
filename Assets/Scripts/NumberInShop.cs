using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberInShop : MonoBehaviour
{
    public Text NumberInImagePanel;
    private Text NumberInStore;
    private int numberInShop;

    // Start is called before the first frame update
    void Start()
    {
        NumberInStore = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        numberInShop = int.Parse(NumberInImagePanel.text);
        NumberInStore.text = numberInShop.ToString();
    }
}
