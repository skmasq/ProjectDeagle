﻿using UnityEngine;
using System.Collections;

public class ApplicationPreferences {

    public const string COMBINE_PREFS = "Combine_Meshes", AVERAGE_PREFS = "Average_Textures", DECREASE_PREFS = "Decrease_Textures", MAX_SIZE = "Max_Texture_Size", MAPS_LOC = "Maps_Location", TEX_LOC = "Textures_Location";
    public static bool fullscreen;

    public static bool averageTextures = false, decreaseTextureSizes = true, combineMeshes = true;
    public static int maxSizeAllowed = 128;
    public static string mapsDir = "D:/Steam/SteamApps/common/Counter-Strike Global Offensive/csgo/maps/";
    public static string texturesDir = "D:/CSGOModels/Textures/";
    public static Color ctColor = new Color(0, 0, 1), tColor = new Color(1, 0, 0);

    public static void LoadSavedPreferences()
    {
        combineMeshes = PlayerPrefs.GetInt(COMBINE_PREFS) != 0;
        averageTextures = PlayerPrefs.GetInt(AVERAGE_PREFS) != 0;
        decreaseTextureSizes = PlayerPrefs.GetInt(DECREASE_PREFS) != 0;
        maxSizeAllowed = PlayerPrefs.GetInt(MAX_SIZE);
        mapsDir = PlayerPrefs.GetString(MAPS_LOC);
        texturesDir = PlayerPrefs.GetString(TEX_LOC);

        fullscreen = Screen.fullScreen;
    }
}
