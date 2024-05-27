using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Transform _transform;
    private SpriteRenderer _spriteRenderer;
    public float speed;
    public float xDirection;
    public float yDirection;
    private void Awake()
    {
        _transform = GetComponent<Transform>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _transform.position = new Vector2(_transform.position.x + speed * xDirection * Time.deltaTime, _transform.position.y + speed * yDirection * Time.deltaTime);
        if (_transform.position.x >= 4.95)
        {
            xDirection = -1;
            _spriteRenderer.flipX = true;
        }
        if (_transform.position.x <= -4.95)
        {
            xDirection = 1;
            _spriteRenderer.flipX = false;
        }
        if (_transform.position.y >= 3.10)
        {
            yDirection = -1;
            _spriteRenderer.flipY = true;
        }
        if (_transform.position.y <= -3.10)
        {
            yDirection = 1;
            _spriteRenderer.flipY = false;
        }
    }
}
