using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum HeadEquipement  { NONE, CHOMPERS, CHILIPEPPER, EYELAZER }
public enum TorsoEquipement { NONE, ROBOARMS, CHESTBEAM, EYELAZER }
public enum TailEquipement  { NONE, SPRING, TRACKS, EYELAZER }

public class StinkyController : MonoBehaviour
{
    Transform       _transform;
    SpriteRenderer  _spriteRenderer;
    Rigidbody2D     _rigidbody;

    private void Start()
    {
        _transform      = transform;
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _rigidbody      = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move(Input.GetAxis("Horizontal") * Vector3.right);
        //if (Input.GetAxis("Horizontal"))
        //    Move(Vector3.right);
        //else if (Input.GetButton("left"))
        //    Move(Vector3.left);
        //else
           
    }

    public void Move(Vector3 direction)
    {
        if (direction.x < 0)
            transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
        else if(direction.x > 0)
            transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

        _rigidbody.velocity = direction * 4;
    }
}
