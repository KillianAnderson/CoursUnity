using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Rocket : MonoBehaviour
{
    public bool monte;
    public float vitesse;
    // public GameObject gameOverMenu;

    public void JumpKeyPressed(InputAction.CallbackContext context)
    {
        // Touche pressée
        if (context.performed)
        {
            monte = true;
        }
        else if (context.canceled)
        {
            monte = false;
        }
    }

    private void Update()
    {
        print("là");
        print(monte);

        if (monte && transform.position.y < 3.5f)
        {
            transform.position += new Vector3(0, 1, 0) * (vitesse * Time.deltaTime);
        }
        else if (!monte && transform.position.y > -3.5f)
        {
            transform.position -= new Vector3(0, 1, 0) * (vitesse * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
        Debug.Log("impact !");
        SceneManager.LoadScene(0);

        // gameOverMenu.SetActive(true);
        // Time.timeScale = 0f;
    }

}
