using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class NetManager : MonoBehaviourPunCallbacks
{
    public static NetManager Instance {
        get {
            return m_Instance;
        }
    }

    public static NetManager m_Instance;

    // Start is called before the first frame update
    void Start()
    {
        m_Instance = this;
        GameObject.DontDestroyOnLoad(gameObject);
        PhotonNetwork.ConnectUsingSettings();
    }

    public void JoinRoomWithID(string roomID)
    {
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 2;
        TypedLobby typedLobby = new TypedLobby("1047", LobbyType.Default);
        PhotonNetwork.JoinOrCreateRoom(roomID,roomOptions,typedLobby);
    }

    public override void OnConnected()
    {
        base.OnConnected();
        StatusBoard.Instance.connectStatus.text = "连接成功";
        Debug.Log("链接成功"+ PhotonNetwork.IsMasterClient);
    }

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        StatusBoard.Instance.connectStatus.text = "已加入房间:" + PhotonNetwork.CurrentRoom.Name;
        Debug.Log("加入房间成功");
    }
}
