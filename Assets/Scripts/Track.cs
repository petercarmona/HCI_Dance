using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Track {

    //----atributes----//

    [SerializeField]
    private string _trackName;
    [SerializeField]
    private AudioClip _song;
    [SerializeField]
    private AudioClip _preview;
    [SerializeField]
    private int _dificulty;
    [SerializeField]
    private string _author;
    
    //----Properties-----//

    public string trackName { get { return _trackName; } set { value = _trackName; } }
    public AudioClip song { get { return _song; } set { value = _song; } }
    public AudioClip preview { get { return _preview; } set { value = _preview; } }
    public int difculty { get { return _dificulty; } set { value = _dificulty; } }
    public string author { get { return _author; } set { value = _author; } }

    //-----Consructors-----//

    Track() 
    {
        _trackName = "undefined";
        _song = null;
        _preview = null;
        _dificulty = -1;    
        _author = "undefined";
    }

    Track(string trackName, AudioClip song, AudioClip preview, int dificulty, string author)
    {
        _trackName = trackName;
        _song = song;
        _preview = preview;
        _dificulty = dificulty;
        _author = author;
    }
}
