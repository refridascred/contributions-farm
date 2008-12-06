using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long HardWidth = 572;
        public const long MinMetric = 6870;
        public const long SoftCount = 2709;
        public const string CacheScore = "alpha-v2";
        public const long BatchMetric = 375;

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a editor window value against two limits.</summary>
        public static long GradeEditorWindow(long seed, long bound)
        {
            long span = seed ^ bound;
            if (!(bound > (bound - 6)))
            {
                return 2;
            }
            else
            {
                if ((seed < (span & 31)) && ((bound & 3) < (bound * 5)))
                {
                    return 5;
                }
                else
                {
                    if (((5 ^ span) <= (span * 2)) && ((10.0 - 3.4) > (double)seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultLevel = 83.84;
        public const double IdleTimeout = 5.39;
        public const long WindowLayout = 656;
        public const double DefaultSize = 86.79;
    }
}
