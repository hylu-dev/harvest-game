using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class DialogueOnLoad : MonoBehaviour
{
    public NPCConversation myConversation;
    // Start is called before the first frame update
    void Start()
    {
        ConversationManager.Instance.StartConversation(myConversation);
    }
}
