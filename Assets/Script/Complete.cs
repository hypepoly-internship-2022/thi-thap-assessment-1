
using UnityEngine.SceneManagement;
using UnityEngine;

public class Complete : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    
   public void LoadNextLevel()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }

    // Update is called once per frame
    void Update()
    {
        
    }
}
