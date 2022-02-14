using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class JMC : MonoBehaviour
{
/// <summary>
/// 
/// </summary>
/// <typeparam name="T"></typeparam>
/// <param name="_List"></param>
/// <returns></returns>
   public static List<T> ShuffleList<T>(List<T> _list)
    {
        for (int i = 0; i < _list.Count; i++)
        {
            T Temp = _list[i];
            int randomIndex = UnityEngine.Random.Range(i, _list.Count);
            _list[i] = _list[randomIndex];
            _list[randomIndex] = Temp;
        }
        return _list;
    }


    /// <summary>
    ///   //returns random colour
    /// </summary>
    /// <returns></returns>
    public Color GetRandomColour()
    {
        return new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }
   

    /// <summary>
    /// fades in canvas
    /// </summary>
    /// <param name="_cvg"></param>
    public void FadeInCanvas(CanvasGroup _cvg)
    {
        _cvg.DOFade(1, 0.5f);
        _cvg.interactable = true;
        _cvg.blocksRaycasts = true;
    }

   /// <summary>
   /// fade out canvas
   /// </summary>
   /// <param name="_cvg"></param>
    public void FadeOutCanvas(CanvasGroup _cvg)
    {
        _cvg.DOFade(0, 0.5f);
        _cvg.interactable = true;
        _cvg.blocksRaycasts = true;
    }
}
