using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

[DebuggerDisplay("{" + nameof(DebuggerDisplay) + "(),nq}")]
public class KeyManager : MonoBehaviour
{
    [SerializeField] GameObject player;

    public bool isPickedUp;
    private Vector2 vel;
    public float smoothTime;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isPickedUp)
        { transform.position = Vector2.SmoothDamp(transform.position, player.transform.position, ref vel, smoothTime); }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("player") && !isPickedUp)
        {
            isPickedUp = true;
        }
    }

    private string DebuggerDisplay => ToString();
}
