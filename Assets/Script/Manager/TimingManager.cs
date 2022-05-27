using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimingManager : MonoBehaviour
{
    [SerializeField]
    Transform Center = null;
    [SerializeField]
    RectTransform[] timingRect = null;

    public List<GameObject> warriorNoteList = null;

    Vector2[] timingBoxs = null;

    void Start()
    {
        timingBoxs = new Vector2[timingRect.Length];

        for (int i = 0; i < timingRect.Length; i++)
        {
            timingBoxs[i].Set(Center.localPosition.x - timingRect[i].rect.width / 2, Center.localPosition.x + timingRect[i].rect.width / 2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckTiming()
    {
        for(int i = 0; i < warriorNoteList.Count; i++)
        {
            float t_notePosX = warriorNoteList[i].transform.localPosition.x;

            for (int x = 0; x < timingBoxs.Length; x++)
            {
                if (timingBoxs[x].x <= t_notePosX && t_notePosX <= timingBoxs[x].y)
                {
                    Debug.Log("Hit" + x);
                    return;
                }
            }
        }
        Debug.Log("Miss");
    }
}
