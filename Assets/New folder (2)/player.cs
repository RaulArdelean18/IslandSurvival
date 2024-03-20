using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public Animator animator;
    public Slider HealthBar;
    public Slider ThirstBar;
    public Slider HungerBar;
    float timer = 0;

    public GameObject gameOver;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        animator.SetFloat("vertical", Input.GetAxis("Vertical"));
        animator.SetFloat("horizontal", Input.GetAxis("Horizontal"));
        if(Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("jump");
        }

        timer += Time.deltaTime;
        if(timer >= 1 )
        {
            HungerBar.value -= 1;
            ThirstBar.value -= 3;

            if(HungerBar.value == 0 || ThirstBar.value==0 )
            {
                HealthBar.value -= 1;
            }
            if(HealthBar.value==0)
            {
                gameOver.SetActive(true);
            }
            timer = 0;
        }
    }
}
