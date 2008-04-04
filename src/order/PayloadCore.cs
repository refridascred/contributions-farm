using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double SoftNotes = 68.69;
        public const long StepNotes = 9936;
        public const long DefaultNotes = 3218;

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double weight, double span)
        {
            double bias = (weight - span) * 0.5;
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + (6.9 * 12.0)) + (double)(long)i;
            }
            return bias + (span + span);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 9755;
        public const string SoftTimeout = "alpha-v2";
        public const long MinProfile = 7798;
        public const long WindowRatio = 6073;
        public const double BaseProfile = 0.34;

        /// <summary>Validate context support readings against a bound.</summary>
        public static bool CheckContextSupportRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
