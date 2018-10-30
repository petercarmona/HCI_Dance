using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManagerAi : MonoBehaviour {

    public GameObject[] musicHolder;
    public Track[] repertory = new Track[5];
    public Material[] mat = new Material[3];

    public int holderSize = 3;
    public float offSet = 3.5f;
    public int musicSelection = 0;

    public Dictionary <int,Track> trackList;
    // Use this for initialization
    void Start() {
        musicHolder = new GameObject[holderSize];
        trackList = new Dictionary<int, Track>();
     
        for (int i = 0; i < holderSize; i++)
        {
            musicHolder[i] = Resources.Load("MusicHolders") as GameObject;
            trackList.Add(i, );
        }

        InstantiateTrackList();
    }
	
	// Update is called once per frame
	void Update () {
        movement();
	}

    void movement()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)){
            Vector3 newPos = transform.position;
            newPos.x += offSet;
            transform.position = newPos;
            musicSelection--;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector3 newPos = transform.position;
            newPos.x -= offSet;
            transform.position = newPos;
            musicSelection++;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        { 
            Transform selectable = transform.Find("Music " + musicSelection);
            Vector3 tmp = selectable.position;
            tmp.y += 2.5f;
            selectable.position = tmp;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {

        }

    }

    void InstantiateTrackList()
    {
        Vector3 tmp = transform.position;
        for (int i = 0; i < holderSize; i++)
        {
            tmp.x = i * 3.5f;

            GameObject go = Instantiate(musicHolder[i], tmp, Quaternion.identity) as GameObject;
            go.transform.SetParent(transform);
            go.name = "Music " + (i);
            go.GetComponent<Renderer>().material = mat[Random.Range(0, 3)];
        }
    }
}
    