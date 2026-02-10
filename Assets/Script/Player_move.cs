using UnityEngine;

public class Player_move : MonoBehaviour
{
    public float velocidade;
    public Vector2 dir;
    public Rigidbody2D rb2d;
    public float JumpForce;
    public bool estaNochao;
    public int vida;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  //aqui estou fazendo o player andar para a direita e a esquerda 
        if (Input.GetKey(KeyCode.D))
        {
            
            dir = new Vector2(+1 * velocidade, rb2d.linearVelocity.y);
        }
        else if(Input.GetKey(KeyCode.A))
        {
            dir = new Vector2(-1 * velocidade, rb2d.linearVelocity.y);
        }
        else

        {
            dir = new Vector2(0, rb2d.linearVelocity.y);
        }
        dir = new Vector2(dir.x, rb2d.linearVelocity.y);
        rb2d.linearVelocity = dir;
        //aqui estou fazendo o player pular 
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W) ) 
        {
           if(estaNochao == true)
            {
                rb2d.AddForce(new Vector2(rb2d.linearVelocity.x, JumpForce));
            }
           
        } 

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {  //aqui o player pula apenas em contato com o chão
        if (collision.gameObject.CompareTag("terrinha"))
        {
            estaNochao = true;

        }
        else if (collision.gameObject.CompareTag("Inimigo"))
        {
            tomaDano(collision.gameObject.GetComponent<Inimigo>().dano);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("moedinha"))
        {
            tomaDano(collision.gameObject.GetComponent<Inimigo>().dano);
            Destroy(collision.gameObject);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    { //aqui ele não da pulo infinito 
        if (collision.gameObject.CompareTag("terrinha"))
        {
            estaNochao = false;

        }
        
    }
    public void tomaDano(int dano)
    {
        vida -= dano;
        if( vida <= 0 )
        {
          Destroy(this.gameObject);

        }
    }
}
