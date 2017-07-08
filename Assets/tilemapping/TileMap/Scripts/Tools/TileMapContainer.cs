using UnityEngine;

namespace MapMaker.TileMapping {
    public class TileMapContainer : ScriptableObject {
        [SerializeField]
        public int width, height;

        [SerializeField]
        public ScriptableTile[ ] map;

    }
}
