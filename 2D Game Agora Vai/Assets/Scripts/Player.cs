using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public int lives;
    public int coins;
    
    public float forcaPulo;
    public float velocidadeMaxima;

    public Text TextLives;
    public Text TextCoins;


    // Start is called before the first frame update
    void Start()
    {
        TextLives.text = lives.ToString();
        TextCoins.text = coins.ToString();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float movimento = Input.GetAxis("Horizontal");
         GetComponent<Rigidbody2D>().velocity = new Vector2(movimento*velocidadeMaxima,GetComponent<Rigidbody2D>().velocity.y);
        
        if (movimento < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;    

        }else if(movimento > 0)
        {
           GetComponent<SpriteRenderer>().flipX = false;
        }
        if(movimento > 0 || movimento < 0){
        GetComponent<Animator>().SetBool("Walking",true);
        }else{
                    GetComponent<Animator>().SetBool("Walking",false);

        }
        
        if(Input.GetKeyDown(KeyCode.Space)){
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0,forcaPulo));
            
        }
        
    }
}
