using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class secondsKeeper {
    private static int seconds;
    private static bool moveOn;
    private static bool show1;
    private static bool show2;
    private static bool show3;
    private static bool music;

    public static int Seconds {
        get {
            return seconds;
        }
        set {
            seconds = value;
        }
    }
    
    public static bool MoveOn {
        get {
            return moveOn;
        }
        set {
            moveOn = value;
        }
    }
    
    public static bool Show1 {
        get {
            return show1;
        }
        set {
            show1 = value;
        }
    }
    
    public static bool Show2 {
        get {
            return show2;
        }
        set {
            show2 = value;
        }
    }
    
    public static bool Show3 {
        get {
            return show3;
        }
        set {
            show3 = value;
        }
    }

    public static bool Music {
        get { return music; }
        set { music = value; }
    }
}
