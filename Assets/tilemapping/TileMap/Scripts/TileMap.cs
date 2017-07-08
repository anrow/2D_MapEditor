using System;
using System.Collections.Generic;
using UnityEngine;

namespace MapMaker.TileMapping {
    [ExecuteInEditMode, AddComponentMenu( "TileMap" ), DisallowMultipleComponent ]
    public class TileMap : MonoBehaviour {
        
        [SerializeField]
        private int width = 25, height = 25;

        [SerializeField]
        private ScriptableTile[ ] map = new ScriptableTile[ 0 ];

        private bool isCurrentOperation = false;

        //private List<ChangeElement> CurrentEdit;
        //private TimeLine timeLine;
        
        public Action<int, int> OnUpdateTileAt = ( x, y ) => { };
        public Action OnUpdateTileMap = ( ) => { };
        public Action<int, int> OnResize = ( width, height ) => { }; 

        public ScriptableTile[ ] Map {
            get {
                return map;
            }
        }
        public int Width {
            get {
                return width;
            }
        }
        public int Height {
            get {
                return height;
            }
        }

        private void Update( ) {

            for( int x = 0; x < Width; x++ ) {
                for( int y = 0; y < Height; y++ ) {

                    //ScriptableTile tile = GetTileAt( x, y );

                    //if( tile && tile.IsCanTick( ) ) {
                    //    UpdateTileAt( x, y );
                    //}
                }
            }
        }
        
       
    }
}
