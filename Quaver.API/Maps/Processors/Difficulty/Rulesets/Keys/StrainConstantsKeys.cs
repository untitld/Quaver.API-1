using Quaver.API.Maps.Processors.Difficulty.Optimization;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quaver.API.Maps.Processors.Difficulty.Rulesets.Keys
{
    public class StrainConstantsKeys : StrainConstants
    {
        /// <summary>
        ///     When Long Notes start/end after this threshold, it will be considered for a specific multiplier.
        ///     Non-Dyanmic Constant. Do not use for optimization.
        /// </summary>
        public float LnEndThresholdMs { get; set; } = 42;

        /// <summary>
        ///     When seperate notes are under this threshold, it will count as a chord.
        ///     Non-Dyanmic Constant. Do not use for optimization.
        /// </summary>
        public float ChordClumpToleranceMs { get; set; } = 8;

        /// <summary>
        ///     Size of each graph partition in miliseconds.
        ///     Non-Dyanmic Constant. Do not use for optimization.
        /// </summary>
        public int GraphIntervalSizeMs { get; set; } = 500;

        /// <summary>
        ///     Offset between each graph partition in miliseconds.
        ///     Non-Dyanmic Constant. Do not use for optimization.
        /// </summary>
        public int GraphIntervalOffsetMs { get; set; } = 100;

        // Simple Jacks
        public float SJackLowerBoundaryMs { get; private set; }
        public float SJackUpperBoundaryMs { get; private set; }
        public float SJackMaxStrainValue { get; private set; }
        public float SJackCurveExponential { get; private set; }

        // Tech Jacks
        public float TJackLowerBoundaryMs { get; private set; }
        public float TJackUpperBoundaryMs { get; private set; }
        public float TJackMaxStrainValue { get; private set; }
        public float TJackCurveExponential { get; private set; }

        // Rolls
        public float RollLowerBoundaryMs { get; private set; }
        public float RollUpperBoundaryMs { get; private set; }
        public float RollMaxStrainValue { get; private set; }
        public float RollCurveExponential { get; private set; }

        // Brackets
        public float BracketLowerBoundaryMs { get; private set; }
        public float BracketUpperBoundaryMs { get; private set; }
        public float BracketMaxStrainValue { get; private set; }
        public float BracketCurveExponential { get; private set; }

        // LN
        public float LnBaseMultiplier { get; private set; }
        public float LnLayerToleranceMs { get; private set; }
        public float LnLayerThresholdMs { get; private set; }
        public float LnReleaseAfterMultiplier { get; private set; }
        public float LnReleaseBeforeMultiplier { get; private set; }
        public float LnTapMultiplier { get; private set; }

        /// <summary>
        ///     Constructor. Create default strain constant values.
        /// </summary>
        public StrainConstantsKeys()
        {
            // Simple Jack
            SJackLowerBoundaryMs = NewConstant("SJackLowerBoundaryMs", 20);
            SJackUpperBoundaryMs = NewConstant("SJackUpperBoundaryMs", 330);
            SJackMaxStrainValue = NewConstant("SJackMaxStrainValue", 83);
            SJackCurveExponential = NewConstant("SJackCurveExponential", 1.20f);

            // Tech Jack
            TJackLowerBoundaryMs = NewConstant("TJackLowerBoundaryMs", 20);
            TJackUpperBoundaryMs = NewConstant("TJackUpperBoundaryMs", 340);
            TJackMaxStrainValue = NewConstant("TJackMaxStrainValue", 85);
            TJackCurveExponential = NewConstant("TJackCurveExponential", 1.16f);

            // Roll/Trill
            RollLowerBoundaryMs = NewConstant("RollLowerBoundaryMs", 20);
            RollUpperBoundaryMs = NewConstant("RollUpperBoundaryMs", 185);
            RollMaxStrainValue = NewConstant("RollMaxStrainValue", 56);
            RollCurveExponential = NewConstant("RollCurveExponential", 1.03f);

            // Bracket
            BracketLowerBoundaryMs = NewConstant("BracketLowerBoundaryMs", 20);
            BracketUpperBoundaryMs = NewConstant("BracketUpperBoundaryMs", 180);
            BracketMaxStrainValue = NewConstant("BracketMaxStrainValue", 57);
            BracketCurveExponential = NewConstant("BracketCurveExponential", 1.05f);

            // LN
            LnBaseMultiplier = NewConstant("LnBaseMultiplier", 0.5f);
            LnLayerToleranceMs = NewConstant("LnLayerToleranceMs", 40f);
            LnLayerThresholdMs = NewConstant("LnLayerThresholdMs", 93.7f);
            LnReleaseAfterMultiplier = NewConstant("LnReleaseAfterMultiplier", 2.25f);
            LnReleaseBeforeMultiplier = NewConstant("LnReleaseBeforeMultiplier", 1.35f);
            LnTapMultiplier = NewConstant("LnTapMultiplier", 1.05f);
        }
    }
}
