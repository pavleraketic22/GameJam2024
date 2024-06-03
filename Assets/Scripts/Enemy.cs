using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Enemy : MonoBehaviour
{
    [SerializeField]
    public GameObject player;
    public float speed;
    public float distanceBetween;
    private float distance;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Vojaz");
    }

    // Update is called once per frame
    void Update()
    {
        if (!(WorldTIme.vreme >= 0 && WorldTIme.vreme <= 5) && !(WorldTIme.vreme >= 21))
        {
            Destroy(gameObject);
            return;
        }
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        if (distance < distanceBetween)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
            //transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        }

    }
}
