    using System;
    using UnityEngine;
    using DG.Tweening;
    public class LockPuzzle:Singleton<LockPuzzle>
    {
        public int[] trueCode;
        public bool[] istrue;
        [SerializeField] private GameObject cantaUst;
        private void Start()
        {
            istrue = new bool[trueCode.Length];
        }

        public void CheckCode(int code,int index)
        {
           if(code==trueCode[index])
           {
               //Debug.Log(index);
               istrue[index]=true;
           }
           else
           {
               istrue[index]=false;
           } 
           CheckAll();
        }
        private void CheckAll()
        {
            for(int i=0;i<istrue.Length;i++)
            {
                if(istrue[i]==false)
                {
                    return;
                }
            }
           
            cantaUst.transform.DORotate(new Vector3(0,180,45), 1f);
            //if all true
            //do something
        }
    }
