using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
	public GameObject hole1Par;
	public GameObject hole2Par;
	public GameObject hole3Par;
	public GameObject totalPar;
	
	public GameObject hole1Strokes;
	public GameObject hole2Strokes;
	public GameObject hole3Strokes;
	public GameObject totalStrokes;
    // Start is called before the first frame update
    void Start()
    {
		switch (DifficultyManager.Difficulty)
            {
                case DifficultyManager.Difficulties.easy:
                    hole1Par.GetComponent<TMPro.TextMeshProUGUI>().text = "4";
					hole2Par.GetComponent<TMPro.TextMeshProUGUI>().text = "4";
					hole3Par.GetComponent<TMPro.TextMeshProUGUI>().text = "4";
					totalPar.GetComponent<TMPro.TextMeshProUGUI>().text = "12";
                    break;
                case DifficultyManager.Difficulties.normal:
                    hole1Par.GetComponent<TMPro.TextMeshProUGUI>().text = "3";
					hole2Par.GetComponent<TMPro.TextMeshProUGUI>().text = "3";
					hole3Par.GetComponent<TMPro.TextMeshProUGUI>().text = "3";
					totalPar.GetComponent<TMPro.TextMeshProUGUI>().text = "9";
                    break;
                case DifficultyManager.Difficulties.hard:
                    hole1Par.GetComponent<TMPro.TextMeshProUGUI>().text = "2";
					hole2Par.GetComponent<TMPro.TextMeshProUGUI>().text = "2";
					hole3Par.GetComponent<TMPro.TextMeshProUGUI>().text = "2";
					totalPar.GetComponent<TMPro.TextMeshProUGUI>().text = "6";
                    break;
            }
			
		hole1Strokes.GetComponent<TMPro.TextMeshProUGUI>().text = GameManager.hole1.ToString();
		hole2Strokes.GetComponent<TMPro.TextMeshProUGUI>().text = GameManager.hole2.ToString();
		hole3Strokes.GetComponent<TMPro.TextMeshProUGUI>().text = GameManager.hole3.ToString();
		totalStrokes.GetComponent<TMPro.TextMeshProUGUI>().text = (GameManager.hole1 + GameManager.hole2 + GameManager.hole3 ).ToString();

        switch (DifficultyManager.Difficulty)
        {
            case DifficultyManager.Difficulties.easy:
                GameManager.maxStrokes = 20;
                GameManager.strokes = 20;
                break;
            case DifficultyManager.Difficulties.normal:
                GameManager.maxStrokes = 15;
                GameManager.strokes = 15;
                break;
            case DifficultyManager.Difficulties.hard:
                GameManager.maxStrokes = 10;
                GameManager.strokes = 10;
                break;
        }
    }

    public void PlayGame()
    {
        GameManager.hole1 = 0;
        GameManager.hole2 = 0;
        GameManager.hole3 = 0;
       
        SceneManager.LoadScene("hole1");
    }
	
	public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
