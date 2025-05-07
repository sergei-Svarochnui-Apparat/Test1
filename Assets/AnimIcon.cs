using DG.Tweening;
using UnityEngine;

public class AnimIcon : MonoBehaviour
{
    private void Start()
    {
        Anim2();
    }

    void Anim1() 
    {
        transform.DOScale(1.2f, 0.3f).SetEase(Ease.InOutBack).SetLoops(-1, LoopType.Yoyo);
    }
    void Anim2() 
    {
        transform.DOShakePosition(0.5f, strength: 10f, vibrato: 20).SetEase(Ease.InOutBack).SetLoops(-1, LoopType.Yoyo);
    }
    void Anim3()
    {
        Sequence seq = DOTween.Sequence();
        seq.Append(transform.DOScale(1.3f, 0.2f));
        seq.Append(transform.DORotate(new Vector3(0, 0, 15), 0.1f));
        seq.Append(transform.DOScale(1f, 0.2f));
        seq.Play().SetLoops(-1, LoopType.Yoyo);
    }
    void Anim4()
    {
        transform.DOJump(transform.position, 0.5f, 1, 0.5f)
             .SetEase(Ease.OutQuad).SetLoops(-1, LoopType.Yoyo);
    }

}
