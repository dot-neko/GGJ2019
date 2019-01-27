using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BubbleManager : MonoBehaviour {

    public Animator animator;
    public Animator content_box;
    public Image content;

    //Haaaaa
	public void StartBubble (Bubble bubble)
    {
        animator.SetBool("IsOpen", true);
        content_box.SetBool("IsOpen", true);
        content.sprite = bubble.content;
        Invoke("EndDialogue", 2.0f);
    }

    public void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
        content_box.SetBool("IsOpen", false);
    }
}
