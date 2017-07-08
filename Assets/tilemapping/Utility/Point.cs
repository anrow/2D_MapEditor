using UnityEngine;

[System.Serializable]

public struct Point {

    public int x;
    public int y;

    public static Point zero  = new Point( 0 ,  0 );
    public static Point one   = new Point( 1 ,  1 );
     
    public static Point up    = new Point( 0 ,  1 );
    public static Point down  = new Point( 0 , -1 );
    public static Point left  = new Point( -1,  0 );
    public static Point right = new Point( 1 ,  0 );
    
    public Point( int x, int y ) {
        this.x = x;
        this.y = y;
    }
}
