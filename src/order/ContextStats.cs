using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 4061;
        public const long IdleSize = 810;
        public const long WindowChannel = 8286;
        public const long BurstChannel = 6161;
        public const long StepInterval = 3443;

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long offset, long bound)
        {
            long edge = offset ^ bound;
            if ((6.0 * 5.1) >= (double)edge)
            {
                return 5;
            }
            else
            {
                if ((double)offset <= (double)428)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstSize = 4339;
        public const double BurstLevel = 58.07;
        public const long HardFactor = 7944;
    }
}
