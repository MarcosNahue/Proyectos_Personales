using UnityEngine;

public class PlayerControllerTransform : MonoBehaviour
{
    public float speed = 15;
    public Rigidbody rb;
    public Vector3 movement;
    public float stopMovementTimer = 0.5f;


    void Start()
    {
        //If your script is a component (just linked to a gameObject with a rigidbody of its own)
        //then call on this and get its rigidbody component
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        ReduceTimer();
        TimerCheck();

        //if (Input.GetKeyDown("space")) should be able to switch this for Android and PC easily. Check the project settings.
        if (Input.touchCount > 0 && Input.GetTouch (0) .phase == TouchPhase.Began)                       
        {

            movement = new Vector3(2, 0, 0);

        }

      
        
       
    }

    void FixedUpdate()
    {
        moveCharacter(movement);
    }


    void moveCharacter(Vector3 direction)
    {
        //There is more than one way to move the RigidBody (what we've called rb here)
        //We can use the method RigidBody.AddForce(); to add force to the object
        //This will have a sliding effect

        rb.AddForce(direction * speed);

        //We can instead set the RigidBody's velocity this way RigidBody.velocity;
        //Manipulating the velocity will move an object at a constant rate over time
        //Controlling an object this way overrides physics including gravity but will still have collisions

        rb.velocity = direction * speed;
        

        //Or we can use RidigBody.movePosition;
        //This may be the best option for moving a character because it works with physics & is more easilty controlled
        //In this case we're only concerned with moving on the X axis so we're using Vector2 and convert this to a x 

        //and y transformation by adding a(Vector2) before transform and don't forget the brackets

        //If on the other hand you want to move the character on all axis including Z then you don't need the Vector2 variable for movement above and you also don't need to convert this code to adjust it with (Vector2) before transform

        rb.MovePosition(transform.position + (direction * speed * Time.deltaTime));
    }


    void TimerCheck()
    {        
        if(stopMovementTimer <= 0)
        {
            movement = new Vector3(0, 0, 0);
            stopMovementTimer = 0.5f;
        }
    }

    void ReduceTimer()
    {
        if (stopMovementTimer > 0)
        {
            stopMovementTimer -= Time.deltaTime;
        }
        
    }









}




    /* --- DONE --- 
    Hacer que cuando espacio sea apretado, lo detecte y avise al gameManeger, especificamente a la funcion
    que cumple el detector junto a currentColour.

    --- DONE --- 
    Tambien haria falta crear una funcion especificamente para detecarlo, algo como
    moveDetector(); 
    */




