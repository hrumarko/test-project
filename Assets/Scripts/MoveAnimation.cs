using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;
public class MoveAnimation : MonoBehaviour
{
    public SkeletonAnimation skeletonAnimation;
    public AnimationReferenceAsset idle, walk;
    public bool isIdle =true;
    void Start()
    {
        SetAnimation(idle, true, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D)){
            
            SetAnimation(idle, true, 1f);
        }
        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D)){
            isIdle =false;
            SetAnimation(walk, true, 1f);
        }

        
        
    }

    void SetAnimation(AnimationReferenceAsset animation, bool loop, float timescale){
        skeletonAnimation.state.SetAnimation(0, animation, loop).TimeScale = timescale;
    }



   
}
