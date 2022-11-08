using UnityEngine;
namespace WineGiraffe

{
    public class FireSystemBase : MonoBehaviour
    {
        [SerializeField, Header("子彈欲製物")]
        private GameObject prefabBullet;
        [SerializeField, Header("子彈生成點")]
        private Transform pointSpawn;

        //生成子彈
        protected void SpawnBullet()
        {
            Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);
        }
    }
}