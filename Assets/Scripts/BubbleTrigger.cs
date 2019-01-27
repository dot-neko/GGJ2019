using UnityEngine;

public class BubbleTrigger : MonoBehaviour {

    public Bubble bubble;
    bool runonce;

    private void Start()
    {
        runonce = false;
        Debug.Log("Iniciando");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (!runonce)
        {
            Debug.Log("Trigger");
            TriggerDialogue();
            runonce = true;
        }
    }

    public void TriggerDialogue()
    {
        FindObjectOfType<BubbleManager>().StartBubble(bubble);
    }

}
