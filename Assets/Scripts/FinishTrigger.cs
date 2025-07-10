using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Victory!");
            SceneManager.LoadScene("VictoryScene"); // נטעין סצנה אחרת
        }
    }
}
