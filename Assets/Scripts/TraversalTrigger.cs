using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraversalTrigger : MonoBehaviour
{
    private TraversalMenu traversalMenu;
    // Start is called before the first frame update
    private void Start() {
        traversalMenu = GetComponent<TraversalMenu>();
    }
    void OnCollisionEnter(Collision collision) {
        traversalMenu.Show();
    }

    void OnCollisionExit(Collision collision) {
        traversalMenu.Hide();
    }
}
