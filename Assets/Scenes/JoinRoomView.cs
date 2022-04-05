using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoinRoomView : MonoBehaviour
{
    public InputField roomID;

    public void OnClickJoin()
    {
        NetManager.Instance.JoinRoomWithID(roomID.text);
    }
}
