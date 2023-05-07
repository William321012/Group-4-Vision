using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CollectablesController : MonoBehaviour
{
    [SerializeField] int ScrapCount;
    [SerializeField] int NewspaperCount;
    [SerializeField] TMP_Text scrapTxt;
    [SerializeField] TMP_Text NewsPaperTxt;

    // Start is called before the first frame update
    void Start()
    {
        ScrapCount = PersistentData.Instance.GetScrapCount();
        NewspaperCount = PersistentData.Instance.GetNewpaperCount();
        scrapTxt.text = ScrapCount + "/15";
        NewsPaperTxt.text = NewspaperCount + "/6";
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void IncreaseFoodScrapCount() {
        ScrapCount = ScrapCount + 1;
        scrapTxt.text = ScrapCount + "/15";
        PersistentData.Instance.SetScrapCount(ScrapCount);
    }

    public void IncreaseNewspaperCount() {
        NewspaperCount = NewspaperCount + 1;
        NewsPaperTxt.text = NewspaperCount + "/6";
        PersistentData.Instance.SetNewspaperCount(NewspaperCount);
    }
}
