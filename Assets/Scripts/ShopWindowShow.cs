using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopWindowShow : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void ShowWindow(bool show)
    {
        animator.SetBool("ShowWindowShop", show);
    }
}
