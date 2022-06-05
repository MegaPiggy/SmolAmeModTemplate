using SALT;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace SmolAmeModTemplate
{
    public class Main : ModEntryPoint
    {
        // THE EXECUTING ASSEMBLY
        public static Assembly execAssembly;

        // Called before MainScript.Awake
        // You want to register new things and enum values here, as well as do all your harmony patching
        public override void PreLoad()
        {
            // Gets the Assembly being executed
            execAssembly = Assembly.GetExecutingAssembly();
            HarmonyInstance.PatchAll(execAssembly);
        }


        // Called before MainScript.Start
        // Used for registering things that require a loaded MainScript
        public override void Load()
        {

        }

        // Called after all mods' Load functions have been called
        // Used for editing existing assets in the game, not a registry step
        public override void PostLoad()
        {

        }


        // Called when the reload command/button is used
        // Configs are reloaded right before this.
        public override void ReLoad()
        {

        }

        // Called when the game is exited
        public override void UnLoad()
        {

        }

        // Called every frame, if ModLoader.CurrentLoadingStep equals LoadingStep.FINISHED
        public override void Update()
        {

        }

        // Called every fixed frame-rate frame, if ModLoader.CurrentLoadingStep equals LoadingStep.FINISHED
        public override void FixedUpdate()
        {

        }

        // Called every frame after all mods' Update functions have been called, if ModLoader.CurrentLoadingStep equals LoadingStep.FINISHED
        public override void LateUpdate()
        {

        }
    }
}