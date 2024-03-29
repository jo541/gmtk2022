﻿using UnityEngine;
using Zenject;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Factory/ResourcesLoaderManagerFactory", order = 1)]
public class PrefabsLoaderManagerFactory : ScriptableObject, IFactory<PrefabsLoaderManager>
{
    public VFXLoader VFXLoader;
    public EnnemiesLoader EnnemiesLoader;
    public PlayerLoader PlayerLoader;
    public WeaponsLoader WeaponsLoader;
    public LevelLoader LevelLoader;
    public DiceLoader DiceLoader;
    public HudLoader HudLoader;

    public PrefabsLoaderManager Create()
    {
        var prefabsLoaderManager = new PrefabsLoaderManager();
        prefabsLoaderManager.VFXLoader = VFXLoader;
        prefabsLoaderManager.EnnemiesLoader = EnnemiesLoader;
        prefabsLoaderManager.PlayerLoader = PlayerLoader;
        prefabsLoaderManager.WeaponsLoader = WeaponsLoader;
        prefabsLoaderManager.LevelLoader = LevelLoader;
        prefabsLoaderManager.DiceLoader = DiceLoader;
        prefabsLoaderManager.HudLoader = HudLoader;

        return prefabsLoaderManager;
    }
}
