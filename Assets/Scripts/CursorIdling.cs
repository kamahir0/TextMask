using UnityEngine;

public class CursorIdling : MonoBehaviour
{
    [SerializeField] private float rotationAmount = 5f; // 回転の振幅
    [SerializeField] private  float rotationSpeed = 1f; // 回転の速度

    [SerializeField] private RectTransform masked;

    private RectTransform thisRect;
    private float initialRotationZ;

    void Start()
    {
        thisRect = GetComponent<RectTransform>();
        initialRotationZ = thisRect.rotation.eulerAngles.z;
    }

    void Update()
    {
        // 時間に応じてsin波の値を計算
        float angle = Mathf.Sin(Time.time * rotationSpeed) * rotationAmount;

        // 初期のZ軸回転にsin波の値を加えて新しい回転を作成
        Quaternion newRotation = Quaternion.Euler(thisRect.rotation.eulerAngles.x, thisRect.rotation.eulerAngles.y, initialRotationZ + angle);

        // 回転を適用
        thisRect.rotation = newRotation;

        masked.anchoredPosition = thisRect.anchoredPosition;
        masked.localScale = thisRect.localScale;
        masked.rotation = newRotation;
    }
}
