﻿/*******************************************************
 * 													   *
 * Asset:		 Touch Controls Kit         		   *
 * Script:		 TCKDPadArrowEditor.cs                 *
 * 													   *
 * Copyright(c): Victor Klepikov					   *
 * Support: 	 http://bit.ly/vk-Support			   *
 * 													   *
 * mySite:       http://vkdemos.ucoz.org			   *
 * myAssets:     http://u3d.as/5Fb                     *
 * myTwitter:	 http://twitter.com/VictorKlepikov	   *
 * 													   *
 *******************************************************/


using UnityEngine;
using UnityEditor;

namespace TouchControlsKit.Inspector
{
    [CustomEditor( typeof( TCKDPadArrow ) )]
    public class TCKDPadArrowEditor : BaseInspector
    {
        private TCKDPadArrow myTarget = null;


        // OnEnable
        void OnEnable()
        {
            myTarget = ( TCKDPadArrow )target;
        }


        // Dirty
        protected override void Dirty()
        {
            EditorUtility.SetDirty( myTarget );
        }        

        // ShowParameters
        protected override void ShowParameters()
        {
            GUILayout.BeginVertical( "Box" );
            GUILayout.Label( "Parameters", StyleHelper.labelStyle );
            StyleHelper.StandartSpace();
            
            GUILayout.BeginHorizontal();
            GUILayout.Label( "Arrow Type", GUILayout.Width( StyleHelper.STANDART_SIZE ) );
            myTarget.ArrowType = ( TCKDPadArrow.ArrowTypes )EditorGUILayout.EnumPopup( myTarget.ArrowType );
            GUILayout.EndHorizontal();

            StyleHelper.StandartSpace();
            GUILayout.EndVertical();
        }
    }
}