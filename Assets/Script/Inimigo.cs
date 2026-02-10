using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public float velocidade;
    public int dano;
    public int vida;
    public Rigidbody2D rd2d;
    public Transform posParair;
    public Transform posParavoltar;
    public float dir = 1; 
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rd2d = GetComponent<Rigidbody2D>();
        rd2d.linearVelocity = new Vector2(velocidade, rd2d.linearVelocity.y);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void MudaDir()
    {
        dir *= -1; 
        rd2d.linearVelocity = new Vector2(velocidade * dir, rd2d.linearVelocity.y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("mudaDir"))
        {
            Debug.Log("akujeisuhdewufruewi");
            MudaDir();
        }
    }
}
