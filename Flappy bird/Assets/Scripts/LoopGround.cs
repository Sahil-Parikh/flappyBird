using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopGround : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;
    [SerializeField] private float _width = 6f;

    private SpriteRenderer _spriteRederer;
    private Vector2 _startSize;
    private void Start()
    {
        _spriteRederer = GetComponent<SpriteRenderer>();

        _startSize = new Vector2(_spriteRederer.size.x, _spriteRederer.size.y);

    }


    // Update is called once per frame
    private void Update()
    {
        _spriteRederer.size = new Vector2(_spriteRederer.size.x + _speed * Time.deltaTime, _spriteRederer.size.y);

        if (_spriteRederer.size.x > _width)
        {
            _spriteRederer.size = _startSize;
        }
    }
}
