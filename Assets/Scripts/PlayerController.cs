using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;
    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float boostSpeed = 7f;
    private SurfaceEffector2D effector;
    float baseSpeed;
    bool canMove = true;
     [SerializeField] float slowSpeed = 2f;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        effector = FindFirstObjectByType<SurfaceEffector2D>();
        baseSpeed = effector.speed;
    }

    public void DisableControls(){
        canMove = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!canMove) return;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            effector.speed = boostSpeed;
        }
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            effector.speed = slowSpeed;
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmount);
        }
        if(Input.GetKey(KeyCode.RightArrow))

            rb2d.AddTorque(-torqueAmount);
    }
}
