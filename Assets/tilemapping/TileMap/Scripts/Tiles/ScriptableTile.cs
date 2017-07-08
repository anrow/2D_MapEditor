using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MapMaker.TileMapping {
    //タイルオブジェクト（tile object）
    public abstract class ScriptableTile : ScriptableObject {

        public string Name {
            get {
                return this.name;
            }
        } 
        public int id {
            get {
                return GetInstanceID( );
            }
        }
        public abstract bool IsValid {
            get;
        }
        /*public abstract Sprite GetSprte( TileMapContainer tileMap = null,
                                         Point postion = default (Point) 
                                        );*/
        public abstract Texture2D GetIcon( );

        //
        private float timeOffset = 0;
        public virtual float tickRate {
            get {
                return 0;
            }
        }
        public bool IsCanTick( ) {
            if( tickRate <= 0 ) {
                return false;
            }
            if( timeOffset - Time.realtimeSinceStartup > tickRate ) {
                timeOffset = 0;
            }
            if( Time.realtimeSinceStartup >= timeOffset ) {
                timeOffset = Time.time + tickRate;
                return IsTick( );
            }
            return false;
        }
        
        protected virtual bool IsTick( ) {
            return false;
        }
    }
}
