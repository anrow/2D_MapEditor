using UnityEngine;

namespace tilemapping {
    public class TileMapContainer : ScriptableObject {
        [SerializeField]
        public int width, height;

        [SerializeField]
        public ScriptableTile[ ] map;

    }
}
