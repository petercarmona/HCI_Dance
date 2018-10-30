using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Track {

    private string _trackName;
    private int _song; // Int being placeholder
    private int _dificulty;
    private string _author;
    
    public string trackName { get { return _trackName; } set { value = _trackName; } }
    public int song { get { return _song; } set { value = _song; } }
    public int difculty { get { return _dificulty; } set { value = _dificulty; } }
    public string author { get { return _author; } set { value = _author; } }

    Track()
    {
        _trackName = "undefined";
        _song = -1;
        _dificulty = -1;
        _author = "undefined";
    }

    Track(string trackName, int song, int dificulty, string author)
    {
        _trackName = trackName;
        _song = song;
        _dificulty = dificulty;
        _author = author;
    }
}
