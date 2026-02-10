using Unity.VisualScripting;
using UnityEngine;

public class Moeda_hehe : MonoBehaviour

{
    public int moeda;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("moedinha"))
        {
            Debug.Log("akujeisuhdewufruewi");

        }
    }
}
