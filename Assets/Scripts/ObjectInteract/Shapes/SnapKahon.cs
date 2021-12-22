using UnityEngine;

public class SnapKahon : MonoBehaviour
{

 //   public Rigidbody rb;
    public AudioClip impact;
    AudioSource audioSource;
    [SerializeField] private GameObject SpawnObject;
    void Start()
    {
    //    rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
        SpawnObject.GetComponent<Renderer>().enabled = false;
    }
    private void OnCollisionEnter(Collision other) 
    {
        if(other.collider.gameObject.tag == "Kahon"){
                print ("Kahon");
                Destroy(other.gameObject);
                SpawnObject.GetComponent<Renderer>().enabled = true;
                audioSource.PlayOneShot(impact, 1F); 
            }        
    }


}