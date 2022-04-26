using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : Singleton<UIManager>
{
   
    
       // public TMP_Text scoreText;

        public TMP_Text bestTimeText;
        public TMP_Text currentTimeText;

    public TMP_Text IKtext;
    public TMP_Text PUText;


   public void update()
    {
        if (_PC.hasInstaKill == true)
        {
            IKtext.text = "Insta Kill is online, take out those enemies!";
        }
      
        
    }
   // IEnumerator IKCount()
   // {
   //     yield return new WaitForSeconds(10);
    //    IKtext.text = "";
   // }
    public void UpdateScore(int _score)
        {
           // scoreText.text = "Score: " + _score;
        }


        public void UpdateCurrentTime(float _time)
        {
            currentTimeText.text = "Current Time:" + _time.ToString("F3");
        }

        public void UpdateBestTime(float _time, bool _firstTime = false)
        {
            if (_firstTime)
                bestTimeText.text = "No Best Time Set Yet";
            else
                bestTimeText.text = "Best Time: " + _time.ToString("F3");
        }
    
}
