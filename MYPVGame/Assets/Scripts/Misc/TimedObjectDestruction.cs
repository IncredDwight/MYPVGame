using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedObjectDestruction : MonoBehaviour
{
    [SerializeField] private float _lifeTime = 1f;

    private float _elapsedTime = 0f;

    // Update is called once per frame
    void Update()
    {
        if (_elapsedTime >= _lifeTime)
            Destroy(this.gameObject);
        else
            _elapsedTime += Time.deltaTime;
    }
}
