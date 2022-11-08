using UnityEngine;

namespace WineGiraffe

{
    /// <summary>
    /// ������� 2D�Ҧ�
    /// </summary>
    public class AirPlaneController : MonoBehaviour
    {
        [Header("���ʳt��")]
        [SerializeField, Range(0, 10)]
        private float speedVertical = 3.5f;
        [SerializeField, Range(0, 10)]
        private float speedHorizontal = 4f;
        [Header("�Ϥ�")]
        [SerializeField]
        private Sprite pictureUp;
        [SerializeField]
        private Sprite pictureMiddle;
        [SerializeField]
        private Sprite pictureDown;

        [SerializeField, Header("�Ϥ���V����")]
        private SpriteRenderer spr;

        private void Update()
        {
            float v = Input.GetAxis("Vertical");
            float h = Input.GetAxis("Horizontal");

            transform.Translate(speedHorizontal * Time.deltaTime * h, speedVertical * Time.deltaTime * v, 0);

            if (v > 0)
            {
                print("���W");
                spr.sprite = pictureUp;
            }
            if (v < 0)
            {
                print("���U");
                spr.sprite = pictureDown;
            }
            if (v == 0)
            {
                print("����");
                spr.sprite = pictureMiddle;
            }
        }
    }

}