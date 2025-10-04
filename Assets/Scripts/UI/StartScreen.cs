using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Core;
using UnityEngine.UI;
using NaughtyAttributes;

public class StartScreen : MonoBehaviour
{
    [Header("Text")]
    [SerializeField] Text storyText;
    [SerializeField] string[] textContent;
    [SerializeField] ScrambleMode scrambleMode;
    [SerializeField] float pageDuration = 1;
    [SerializeField] float textDuration = 1;
    [SerializeField] string allText;

    [SerializeField] CanvasGroup canvasGroup;
    [SerializeField] RectTransform rectTransform;
    [SerializeField] float fadeTime = 1;

    private void Start()
    {
        //FadeInPanel();
        TextTest();
    }


    [Button]
    public void TextTest()
    {
        storyText.text = "";
        storyText.DOText(
            allText,
            duration: textDuration
            ).SetSpeedBased(true).OnComplete(()=>gameObject.SetActive(false));
        rectTransform.DOAnchorPos(new Vector2(0, 819.7f), pageDuration).SetSpeedBased(true);
    }

    void SkipToNextText(int i)
    {
        i++;
        if (i <= textContent.Length)
        {
            storyText.text = " ";
            storyText.DOText(
                textContent[i],
                duration: textDuration
                ).OnComplete(() => SkipToNextText(i));
        }
       
    }
    public void FadeInPanel() // open panel button
    {
        canvasGroup.alpha = 0;
        //rectTransform.transform.localPosition = new Vector3(0, -2500f, 0);
        rectTransform.DOAnchorPos(Vector2.zero, fadeTime, false).SetEase(Ease.OutElastic);
        canvasGroup.DOFade(1, fadeTime);
        //StartCoroutine(AnimateItems());
    }

    public IEnumerator FadeOutPanel() // back button
    {
        yield return new WaitForSeconds(12);
        canvasGroup.alpha = 1;
        rectTransform.transform.localPosition = new Vector3(0, 0, 0);
        rectTransform.DOAnchorPos(new Vector2(0, -2500f), fadeTime, false).SetEase(Ease.InOutQuint);
        canvasGroup.DOFade(0.5f, fadeTime);
    }
}
