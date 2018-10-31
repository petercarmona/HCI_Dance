using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManagerAi : MonoBehaviour {

    public GameObject[] musicHolder; // 3d model for the music img
    public Track[] repertory; // List of Tracks
    public Material[] mat = new Material[3]; // Temporary image placeholder

    public int holderSize = 3; // Indicates the number of tracks
    public float offSet = 3.5f; // Offset of the 3d models (MusicHolder)
    public int musicSelection = 0; // counter for the music to play
    
    public Dictionary <int,Track> trackList;

    // Use this for initialization
    void Start() {

        musicHolder = new GameObject[holderSize];
        repertory = new Track[holderSize];
        trackList = new Dictionary<int, Track>();
     
        for (int i = 0; i < holderSize; i++)
        {
            musicHolder[i] = Resources.Load("MusicHolders") as GameObject;
            trackList.Add(i, repertory[i]);
        }
 
        InstantiateTrackList();
    }
	
	// Update is called once per frame
	void Update () {
        movement();
	}

    void movement()
    {
        ///-----INPUTS!-----//

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
    