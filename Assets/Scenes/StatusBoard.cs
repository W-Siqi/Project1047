using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusBoard : MonoBehaviour
{
    public static StatusBoard Instance
    {
        get
        {
            return m_Instance;
        }
    }

    public static StatusBoard m_Instance;

    private void Awake()
    {
        m_Instance = this;
    }

    public Text connectStatus;
}
