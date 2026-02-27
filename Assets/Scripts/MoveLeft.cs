using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 10f;
    PlayerController player;

    private void Awake()
    {
        GameObject go = GameObject.Find("Player");
        player = go.GetComponent<PlayerController>();
        
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (player.isGameOver == false)
        {
            transform.Translate(speed * Time.deltaTime * Vector3.left);
        }
    }
}
