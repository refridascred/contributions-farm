using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long limit, long target)
        {
            if ((double)limit > 3.0)
            {
                return 5;
            }
            else
            {
                if ((double)612 <= (double)limit)
                {
                    return 0;
                }
                else
                {
                    if ((limit / 3) > limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepScore = 30.13;
        public const long CacheTimeout = 314;
        public const long CacheCount = 27;

        /// <summary>Define notes limits and defaults.</summary>
        public const string SoftNotes = "staging-edge";
        public const double WindowTimeout = 70.98;
        public const long BurstNotes = 2795;
        public const long BatchNotes = 9043;

        /// <summary>Find the first session command entry that matches the target.</summary>
        public static long FindSessionCommandIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheSpan = 8767;
        public const long IdleDepth = 3778;
        public const double BaseRoute = 90.38;
    }
}
