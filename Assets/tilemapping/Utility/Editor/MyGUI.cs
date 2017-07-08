using UnityEngine;
using UnityEditor;

namespace MapMaker.Utility {

    public static class MyGUILayout {

        //スプリッタの色
        private static readonly Color splitterColor = 
            EditorGUIUtility.isProSkin ? 
            new Color( 0.157f, 0.157f, 0.157f ) : 
            new Color( 0.5f  , 0.5f  , 0.5f   ) ;

        public static void Splitter( Color rgb, float thickness = 1.0f ) {

            Rect position = GUILayoutUtility.GetRect( GUIContent.none,
                                                      MyStyles.splitter,
                                                      GUILayout.Height( thickness )
                                                     );

            if( Event.current.type == EventType.Repaint ) {
                Color restoreColor = UnityEngine.GUI.color;
                GUI.color = rgb;
                MyStyles.splitter.Draw( position, false, false, false, false );
                GUI.color = restoreColor;
            }
        }

        public static void Splitter( float thickness, GUIStyle splitterStyle ) {

            Rect position = GUILayoutUtility.GetRect( GUIContent.none,
                                                      MyStyles.splitter,
                                                      GUILayout.Height( thickness )
                                                     );

            if( Event.current.type == EventType.Repaint ) {
                Color restoreColor = GUI.color;
                GUI.color = splitterColor;
                splitterStyle.Draw( position, false, false, false, false );
                GUI.color = restoreColor;
            }
                
        }

        public static void Splitter( float thickness = 1.0f ) {
            Splitter( thickness, MyStyles.splitter );
        }

        public static void Link( string text, string URL, GUIStyle style, params GUILayoutOption[ ] options ) {
			GUILayout.Label( text, style, options );
			Rect r = GUILayoutUtility.GetLastRect( );
			if( Event.current.type == EventType.MouseUp && r.Contains (Event.current.mousePosition ) ) {
				Application.OpenURL (URL);
            }
		}
		public static void Link( GUIContent content, string URL, params GUILayoutOption[ ] options ) {
			GUILayout.Label( content, options );
			Rect r = GUILayoutUtility.GetLastRect( );
			if( Event.current.type == EventType.MouseUp && r.Contains( Event.current.mousePosition ) ) {
				Application.OpenURL (URL);
            }
		}
		public static void Link( GUIContent content, GUIStyle style,string URL, params GUILayoutOption[ ] options ) {
			GUILayout.Label( content, style, options );
			Rect r = GUILayoutUtility.GetLastRect( );
			if( Event.current.type == EventType.MouseUp && r.Contains( Event.current.mousePosition ) ) {
				Application.OpenURL (URL);
            }
		}
	
    }

    public static class MyStyles {

        public static readonly GUIStyle splitter;
        public static readonly GUIStyle wrappedLabel;
        public static readonly GUIStyle centerMiniLabel;
        public static readonly GUIStyle leftBoldLabel;
        public static readonly GUIStyle leftMiniLabel;
        public static readonly GUIStyle centerBoldLabel;
        public static readonly GUIStyle centerWhiteBoldLabel;
        public static readonly GUIStyle centerWhiteMiniLabel;
        
        static MyStyles( ) {
            splitter = new GUIStyle( );
            splitter.normal.background = EditorGUIUtility.whiteTexture;
            splitter.stretchWidth = true;
            splitter.margin = new RectOffset( 0, 0, 7, 7 );
            
            centerWhiteBoldLabel = new GUIStyle( EditorStyles.whiteBoldLabel );
            centerWhiteBoldLabel.alignment = TextAnchor.MiddleCenter;
            centerWhiteBoldLabel.wordWrap = true;

            leftBoldLabel = new GUIStyle( EditorStyles.boldLabel );
			leftBoldLabel.alignment = TextAnchor.MiddleLeft;
			leftBoldLabel.wordWrap = true;

			leftMiniLabel = new GUIStyle( EditorStyles.miniLabel );
			leftMiniLabel.alignment = TextAnchor.MiddleLeft;
			leftMiniLabel.wordWrap = true;

			centerBoldLabel = new GUIStyle( EditorStyles.boldLabel );
			centerBoldLabel.alignment = TextAnchor.MiddleCenter;
			centerBoldLabel.wordWrap = true;

			wrappedLabel = new GUIStyle( EditorStyles.label );
			wrappedLabel.wordWrap = true;
        }
    }
}
