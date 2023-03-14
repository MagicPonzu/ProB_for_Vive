using UnityEngine;
using System;
using Valve.VR;

public class UkulelePosition : MonoBehaviour
{
     //トラッカーの位置座標格納用
    private Vector3 Tracker1Posision;

    //トラッカーの回転座標格納用（クォータニオン）
    private Quaternion Tracker1RotationQ;
    //トラッカーの回転座標格納用（オイラー角）
    private Vector3 Tracker1Rotation;

    //トラッカーのpose情報を取得するためにtracker1という関数にSteamVR_Actions.default_Poseを固定
    private SteamVR_Action_Pose tracker1 = SteamVR_Actions.default_Pose;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // transformを取得
        Transform myTransform = this.transform;
        Vector3 pos = myTransform.position;
        Quaternion rot = myTransform.rotation;

        //位置座標を取得
        Tracker1Posision = tracker1.GetLocalPosition(SteamVR_Input_Sources.Waist);
        //回転座標をクォータニオンで値を受け取る
        Tracker1RotationQ = tracker1.GetLocalRotation(SteamVR_Input_Sources.Waist);
        //取得した値をクォータニオン → オイラー角に変換
        Tracker1Rotation = Tracker1RotationQ.eulerAngles;

        pos = Tracker1Posision;
        rot = Tracker1RotationQ;
        myTransform.position = pos;
        myTransform.rotation = rot;

        //取得したデータを表示（T1D：Tracker1位置，T1R：Tracker1回転）
        Debug.Log("T1D:" + Tracker1Posision.x + ", " + Tracker1Posision.y + ", " + Tracker1Posision.z + "\n" +
                    "T1R:" + Tracker1Rotation.x + ", " + Tracker1Rotation.y + ", " + Tracker1Rotation.z);
    }
}
