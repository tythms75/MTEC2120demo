using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
using UnityEngine;

public class SitScript : MonoBehaviour
{
    public Transform sittingPosition; 
    private bool isSitting = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (isSitting)
            {
                StandUp();
            }
            else
            {
                SitDown();
            }
        }
    }

    void SitDown()
    {
        isSitting = true;
        
        transform.position = sittingPosition.position;
        transform.rotation = sittingPosition.rotation;
        
    }

    void StandUp()
    {
        isSitting = false;
        
    }
}
