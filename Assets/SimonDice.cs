using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimonDice : MonoBehaviour
{
  public Text displayText;
  public AudioSource audioSource;

  private Color[] colors = { Color.white, Color.clear };
  private List<Color> sequence = new List<Color>();
  private int nextColorIndex = 0;
  private bool isPlaying = false;

  void Start()
  {
    // Generar una secuencia aleatoria de colores
    for (int i = 0; i < 6; i++)
    {
      sequence.Add(colors[Random.Range(0, colors.Length)]);
    }
  }

  void Update()
  {
    if (isPlaying)
    {
      displayText.text = "Siguiente color: " + sequence[nextColorIndex];
      displayImage.color = sequence[nextColorIndex];

      if (Input.GetKeyDown(KeyCode.Space))
      {
        if (nextColorIndex == sequence.Count)
        {
          Debug.Log("¡Ganaste!");
          isPlaying = false;
        }
        else
        {
          nextColorIndex++;
          audioSource.Play();
        }
      }
    }
    else
    {
      displayText.text = "Presiona Enter para empezar";
      displayImage.color = Color.black;

      if (Input.GetKeyDown(KeyCode.Return))
      {
        isPlaying = true;
      }
    }
  }
}
