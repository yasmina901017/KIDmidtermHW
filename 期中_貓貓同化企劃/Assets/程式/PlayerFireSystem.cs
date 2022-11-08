using UnityEngine;

namespace WineGiraffe

{
    public class PlayerFireSystem : FireSystemBase
    {
        private void Update()
        {
            //如果玩家按下空白鍵就生成子彈
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpawnBullet();
            }
        }


    }
}