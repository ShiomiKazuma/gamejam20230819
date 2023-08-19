using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button1Script : MonoBehaviour
{
    Button button_1;

    [SerializeField]
    private SceneObject scene;

    void Start()
    {
        button_1 = gameObject.GetComponent<Button>();
        button_1.onClick.AddListener(delegate { ChangeScene(scene); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    void ChangeScene(SceneObject newScene)
    {
        SceneManager.LoadScene(newScene);
    }
}
