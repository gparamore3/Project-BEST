using UnityEngine;

public class NewEmptyCSharpScript : MonoBehaviour
{

    public float speed;

    //Start is called before the first frame update.
    private void Start()
    {
        
    }

    //Update is called once per frame.
    private void Update()
    {

        Vector3 playerInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        transform.position += playerInput.normalized * speed * Time.deltaTime;
    }




}
