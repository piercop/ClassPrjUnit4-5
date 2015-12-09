﻿/*********************************************************************
 * This code is written by and belongs to DFT Games Ltd.
 * *******************************************************************
 * The license governing this asset id the Unity Asset Store EULA,
 * found here: http://unity3d.com/es/legal/as_terms hereby summarised:
 * *******************************************************************
 * Usage is granted to the licensee in conjunction with the
 * package that has been licensed and also in other final products
 * produced by the licensee and aimed to an end user.
 * It's forbidden to use this code as part of packages or assets
 * aimed to be used by developers other than the licensee
 * of the original package.
 * *******************************************************************
 *
 * Copyright 2010-2015 - DFT Games Ltd. - Version 6.3 (4 Oct. 2015)
 *
 * *******************************************************************
 */

using UnityEditor;
using UnityEngine;

namespace DFTGames.Tools.EditorTools
{
    public static partial class ResourceHelper
    {
        public static Texture LogoFadeObstructors = EditorGUIUtility.LoadRequired(string.Format("{0}/fo_inspector_header.png", DFTGamesFolderPath)) as Texture;
        public static Texture LogoFadeObstructorsVolumetric = EditorGUIUtility.LoadRequired(string.Format("{0}/fov_inspector_header.png", DFTGamesFolderPath)) as Texture;
        public static Texture LogoFSM = EditorGUIUtility.LoadRequired(string.Format("{0}/Logogruppo.png", DFTGamesFolderPath)) as Texture;
        public static Texture Icon1= EditorGUIUtility.LoadRequired(string.Format("{0}/3.png", DFTGamesFolderPath)) as Texture;
        public static Texture Icon2 = EditorGUIUtility.LoadRequired(string.Format("{0}/5.png", DFTGamesFolderPath)) as Texture;



    }
}