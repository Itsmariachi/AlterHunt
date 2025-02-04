using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using JetBrains.Annotations;

public class Variables : MonoBehaviour
{
    public int health = 100;
    public const int alive = 200;
    public string firstName;
    public string lastName;
    private TextMeshProUGUI textMeshPro;
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        textMeshPro.text = $"Hello {firstName + " " + lastName}!";
    }
    void Update()
    {
    }
}
