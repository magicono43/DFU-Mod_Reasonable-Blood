// Project:         ReasonableBlood mod for Daggerfall Unity (http://www.dfworkshop.net)
// Copyright:       Copyright (C) 2020 Kirk.O
// License:         MIT License (http://www.opensource.org/licenses/mit-license.php)
// Author:          Kirk.O
// Created On: 	    7/25/2020, 2:45 PM
// Last Edit:		5/17/2024, 10:45 PM
// Version:			1.05
// Special Thanks:  Jehuty
// Modifier:

using DaggerfallWorkshop.Game;
using DaggerfallWorkshop.Game.Utility.ModSupport;
using DaggerfallWorkshop.Utility;
using UnityEngine;

namespace ReasonableBlood
{
    public class ReasonableBlood : MonoBehaviour
    {
        static Mod mod;

        [Invoke(StateManager.StateTypes.Start, 0)]
        public static void Init(InitParams initParams)
        {
            mod = initParams.Mod;
            var go = new GameObject("ReasonableBlood");
            go.AddComponent<ReasonableBlood>();
        }
        
        void Awake()
        {
            InitMod();

            mod.IsReady = true;
        }
        
        #region InitMod and Settings
        
        private static void InitMod()
        {
            Debug.Log("Begin mod init: ReasonableBlood");
            
            // Spriggan
            EnemyBasics.Enemies[2].BloodIndex = 2;
            
            // Gargoyle
            EnemyBasics.Enemies[22].BloodIndex = 2;
            
            // Fire Atronach
            EnemyBasics.Enemies[35].BloodIndex = 2;
            
            // Iron Atronach
            EnemyBasics.Enemies[36].BloodIndex = 2; // I'd like to add more hit effects, but for right now, don't know if that's easily possible, so this should work for the time.
            
            // Ice Atronach
            EnemyBasics.Enemies[38].BloodIndex = 2;
            
            // Frost Daedra
            EnemyBasics.Enemies[25].BloodIndex = 2;
            
            // Fire Daedra
            EnemyBasics.Enemies[26].BloodIndex = 2;

            Debug.Log("Finished mod init: ReasonableBlood");
        }

        #endregion

    }
}