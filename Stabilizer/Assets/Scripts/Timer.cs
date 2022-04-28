using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class Timer : MonoBehaviour
    {
        public float timeValue = 0;
        public Text textTimer;

        public bool timeRunning = false;

        public void Start()
        {
            textTimer.text = timeValue.ToString("F2");
        }

        private void Update()
        {
            if(timeRunning == true)
            {
                timeValue += Time.deltaTime;
                textTimer.text = timeValue.ToString("F2");
            }

            if((timeRunning == false) && (timeValue == 0))
            {
                textTimer.text = timeValue.ToString("F2");
            }

        }

    }
}
