using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class MainManager : MonoBehaviour
    {
        public static MainManager Instance;
        public int selectedButton = 0;
        public bool isLionVisible = false;
        public void Awake()
        {
            if (Instance != null)
            {
                Destroy(gameObject);
                return;
            }
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        private void Update()
        {
           
        }

    }

