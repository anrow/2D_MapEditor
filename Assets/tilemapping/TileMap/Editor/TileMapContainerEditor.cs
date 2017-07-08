using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace MapMaker.TileMapping {

    [CustomEditor(typeof(TileMapContainer))] 
    public class TileMapContainerEditor : Editor {

        TileMapContainer container;

        public override void OnInspectorGUI( ) {
            container = ( target as TileMapContainer );
            EditorGUILayout.HelpBox( "タイルマップのコンテナのデータ", MessageType.Info );

            Utility.MyGUILayout.Splitter( );
            if( GUILayout.Button( "新しいタイルマップをインポート" ) ) {

                GameObject go = new GameObject( container.name );
                
            }
            
        }
    }

}
