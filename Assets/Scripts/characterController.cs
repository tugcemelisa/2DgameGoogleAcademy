using UnityEngine;

public class characterController : MonoBehaviour
{
    public float speed = 1.0f;
    private Rigidbody2D r2d;
    private Animator animator;
    private Vector3 charPos;
    private SpriteRenderer spriteRenderer;
    [SerializeField] private GameObject camera; // editörde gözükür
    private int sayi;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // caching spriterenderer
        r2d = GetComponent<Rigidbody2D>(); // caching r2d
        animator = GetComponent<Animator>(); // caching anim
        charPos = transform.position;
        sayi = 1;
    }

    private void FixedUpdate() 
    {

        // r2d.velocity = new Vector2(x: speed, y: 0f);
        sayi = 2;
    
    }

    void Update() 
    {

        transform.position += new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0); // z otomatik 0 alır
        // transform.position += charPos; //Hesapladıgım pozisyon karakterime işlensin
        if(Input.GetAxis("Horizontal") == 0.0f)
        {
            animator.SetFloat(name: "speed", value: 0.0f);
        }
        else 
        {
            animator.SetFloat(name: "speed", value: 1.0f);
        }
        if(Input.GetAxis("Horizontal") > 0.0f) 
        {
            spriteRenderer.flipX = false;

        } else if(Input.GetAxis("Horizontal") < 0.0f)
        {
            spriteRenderer.flipX = true;
        }

        animator.SetFloat("speed", speed);
        sayi = 3;
        Debug.Log("Update" + sayi);
    }
    private void LateUpdate()
    {
        // camera.transform.position = new Vector3(charPos.x, y:charPos.y, z:charPos.z - 1.0f);
        sayi = 4;
    }
}

