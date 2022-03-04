using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerScoring : Singleton<TimerScoring>
{
  
        public float bestTime;
        public float currentTime;
        Timer timer;
        void Start()
        {
            ///cjange 10000 to 1 for count up

            if (PlayerPrefs.HasKey("BestTime"))
            {
                bestTime = PlayerPrefs.GetFloat("BestTime");
                _UI.UpdateBestTime(bestTime);
            }
            else
            {
                bestTime = 1;
                _UI.UpdateBestTime(bestTime, true);
            }


            timer = FindObjectOfType<Timer>();
            timer.StartTimer();
        }

       
        void Update()
        {
            if (timer.IsTiming())
            {
                _UI.UpdateCurrentTime(timer.GetTime());
            }

            if (Input.GetKeyDown(KeyCode.F))
                GameOver();

            if (Input.GetKeyDown(KeyCode.P))
                PlayerPrefs.DeleteAll();
        }

       public void GameOver()
        {
            timer.StopTimer();
            currentTime = timer.GetTime();
            if (currentTime > bestTime)
            {
                bestTime = currentTime;
                PlayerPrefs.SetFloat("BestTime", bestTime);
                _UI.UpdateBestTime(bestTime);
            }
        }
    
}
