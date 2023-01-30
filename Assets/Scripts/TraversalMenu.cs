using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class TraversalMenu : MonoBehaviour {
    [SerializeField] private RectTransform buttonTemplate;
    [SerializeField] private RectTransform buttonContainer;

    public string[] sceneNames;

    List<GameObject> tempButtons = new List<GameObject>();

    public void Show() {
        float buttonContainerHeight = 0;
        foreach (string sceneName in sceneNames) {
            GameObject button = Instantiate(buttonTemplate.gameObject, buttonContainer);
            button.gameObject.SetActive(true);
            button.GetComponent<TMP_Text>().text = sceneName.Substring(0, sceneName.IndexOf("Day"));
            button.GetComponent<Button>().onClick.AddListener(() => ChangeScene(sceneName));
            tempButtons.Add(button);
            buttonContainerHeight += buttonTemplate.sizeDelta.y;
        }
        buttonContainer.sizeDelta = new Vector2(buttonContainer.sizeDelta.x, buttonContainerHeight);
        buttonContainer.gameObject.SetActive(true);
    }

    private void ChangeScene(string sceneName) {
        Hide();
        SceneManager.LoadScene(sceneName);
        
    }
    public void Hide() {
        buttonContainer.gameObject.SetActive(false);
        foreach (GameObject button in tempButtons) {
            Destroy(button);
        }
        tempButtons.Clear();
    }
}