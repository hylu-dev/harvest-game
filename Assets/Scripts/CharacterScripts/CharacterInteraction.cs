using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class CharacterInteraction : MonoBehaviour
{
    public NPCConversation myConversation;
    [SerializeField] int minConversationDistance;

    public void Update() {
        float conversationDistance = Vector3.Distance(transform.position, GameObject.FindGameObjectWithTag("Player").transform.position);
        if (Input.GetKey(KeyCode.Space) && conversationDistance <= minConversationDistance) {
            ConversationManager.Instance.StartConversation(myConversation);
            ConversationManager.Instance.SetInt("moral", PlayerState.moral);
            ConversationManager.Instance.SetBool("helped_mal", PlayerState.helped_mal);
            ConversationManager.Instance.SetBool("helped_cass", PlayerState.helped_cass);
            ConversationManager.Instance.SetBool("has_book", PlayerState.has_book);
            ConversationManager.Instance.SetBool("has_money", PlayerState.has_money);
            ConversationManager.Instance.SetBool("has_food", PlayerState.has_food);
            ConversationManager.Instance.SetBool("overtime", PlayerState.overtime);
            Debug.Log(PlayerState.moral);
        }
    }
}
