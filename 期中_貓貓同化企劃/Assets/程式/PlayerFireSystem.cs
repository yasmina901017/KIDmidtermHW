using UnityEngine;

namespace WineGiraffe

{
    public class PlayerFireSystem : FireSystemBase
    {
        private void Update()
        {
            //�p�G���a���U�ť���N�ͦ��l�u
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpawnBullet();
            }
        }


    }
}