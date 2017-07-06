using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tilemapping {
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

        private float timeOffset = 0;
        public virtual float tickRate {
            get {
                return 0;
            }
        }

        
    }
}
