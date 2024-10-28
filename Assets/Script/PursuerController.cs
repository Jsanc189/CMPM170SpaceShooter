using UnityEngine;

public class PursuerController : MonoBehaviour
{
    public float damage;
    public GameObject target;
    public float movementSpeed;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 direction = (target.transform.position - transform.position).normalized;
        transform.position += direction * movementSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        UnitController unit = other.GetComponent<UnitController>();
        if (unit != null)
        {
            if (unit.player != target)
                unit.Damage(damage);
        }
    }
}
