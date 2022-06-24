using Spine.Unity;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Animate : MonoBehaviour
{
    // Start is called before the first frame update
    private SkeletonAnimation _animation;
    private TextMeshProUGUI _textMesh;
    void Awake()
    {
        _animation = gameObject.GetComponent<SkeletonAnimation>();
        _textMesh = FindObjectOfType<TextMeshProUGUI>();
        
    }

    IEnumerator Start()
    {
        yield return new WaitForSeconds(1f);
        StartCoroutine(RunAnimation());
    }
    // Update is called once per frame
    IEnumerator RunAnimation()
    {
        yield return new WaitForSeconds(1f);
        foreach(Spine.Animation animation in _animation.Skeleton.Data.Animations)
        {
            _animation.AnimationName = animation.Name;
            _textMesh.text = animation.Name;
            yield return new WaitForSeconds(3f);
        }
    }
}
