using UnityEngine;
namespace WineGiraffe

{
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("�|�y���ˮ`���ؼ�")]
        private string nameTarget;
        [SerializeField, Header("�z���w�m��")]
        private GameObject prefabExplosion;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            //print("�I��:" + collision.gameObject);

            if (collision.gameObject.name.Contains(nameTarget))
            {
                Instantiate(prefabExplosion, transform.position, transform.rotation);

                Destroy(gameObject);
            }
        }
        private void OnCollisionExit2D(Collision2D collision)
        {

        }

        private void OnCollisionStay2D(Collision2D collision)
        {

        }

    }
}