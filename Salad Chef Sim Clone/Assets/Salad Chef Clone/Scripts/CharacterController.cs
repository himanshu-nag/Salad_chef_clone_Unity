using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private string axisH, axisV;
    public float m_speed;

    private void Start()
    {
        axisH = name + "Horizontal";
        axisV = name + "Vertical";
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(m_speed * Input.GetAxis(axisH) * Time.deltaTime, 0f, m_speed * Input.GetAxis(axisV) * Time.deltaTime);
    }
}

