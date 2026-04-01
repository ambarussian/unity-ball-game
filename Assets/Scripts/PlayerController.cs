using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public int speed;
    private int scoreboard;
    public Text txtScore;
    public Text txtVictory;
    public Button btnAgain;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        scoreboard = 0;
        txtVictory.gameObject.SetActive(false);
        btnAgain.gameObject.SetActive(false);
    }

    void FixedUpdate()
    {
        // User input
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");   

        Vector3 force = new Vector3(horizontalMove, 0, verticalMove);

        // Strength base on input
        rb.AddForce(force * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Collectible"))
        {
            other.gameObject.SetActive(false);
            scoreboard++;
            txtScore.text = "Scoreboard: " + scoreboard;
            showEnding();
        }
    }
    private void showEnding()
    {
        if (scoreboard==5)
        {
            txtVictory.gameObject.SetActive(true);
            btnAgain.gameObject.SetActive(true);
        }
    }
    public void AgainScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}