using UnityEngine;
namespace WineGiraffe

{
    public class FireSystemBase : MonoBehaviour
    {
        [SerializeField, Header("�l�u���s��")]
        private GameObject prefabBullet;
        [SerializeField, Header("�l�u�ͦ��I")]
        private Transform pointSpawn;

        //�ͦ��l�u
        protected void SpawnBullet()
        {
            Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);
        }
    }
}