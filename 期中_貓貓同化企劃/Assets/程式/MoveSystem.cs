using UnityEngine;

namespace WineGiraffe

{
    /// <summary>
    /// ���ʨt��
    /// </summary>
    public class MoveSystem : MonoBehaviour
    {
        [SerializeField, Header("���ʳt��"), Range(-10, 0)]
        private float speed = -3.5f;

        private void Update()
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
    }
}