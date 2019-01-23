using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject linterna;
    [SerializeField] AudioSource audioSource;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L)){
            linterna.SetActive(!linterna.activeSelf);
        }
        if (Input.GetButtonDown("Fire1")) {
            audioSource.Play();
        }
    }
}