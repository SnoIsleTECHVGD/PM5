
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{

    [SerializeField] private AudioClip chechpointSound;
    private Transform currentCheckpoint;
    private Health playerHealth;

    private void Awake()
    {
        playerHealth = GetComponent<Health>();
    }


    public void Respawn()
    {
        transform.position = currentCheckpoint.position;
        playerHealth.Respawn();



    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "Checkpoint")
        {
          currentCheckpoint = collision.transform;
            SoundManager.instance.PlayerSound(checkpointSound);
            collision.GetComponent<Collider2D>().enabled = false;
            collision.GetComponent<Animator>().SetTrigger("appear");
        }





    }
    
    
    
  




}
