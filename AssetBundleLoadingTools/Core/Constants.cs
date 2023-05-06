﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetBundleLoadingTools.Core
{
    public static class Constants
    {
        public const string SinglePassKeyword = "UNITY_SINGLE_PASS_STEREO";
        public const string SinglePassInstancedKeyword = "STEREO_INSTANCING_ON";

        public const string ManifestFileName = "manifest.json";
        public const string BundleFileName = "shaders.asset";

        public static readonly string UserDataPath = Path.Combine(IPA.Utilities.UnityGame.InstallPath, "UserData", "AssetBundleLoadingTools");
        public static readonly string CachePath = Path.Combine(UserDataPath, "Cache");
        public static readonly string ShaderBundlePath = Path.Combine(UserDataPath, "ShaderBundles");
        public static readonly string DebuggingPath = Path.Combine(UserDataPath, "Debugging");
    }
}