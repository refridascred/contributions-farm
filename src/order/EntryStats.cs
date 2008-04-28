using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 2230;
        public const double HardTools = 2.25;
        public const long StepWidth = 3059;
        public const double BaseBudget = 17.94;
        public const double MinBudget = 61.49;

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Stamp { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long bound, long floor)
        {
            long bound2 = bound - floor;
            if (!((floor << 2) < 7))
            {
                return 4;
            }
            else
            {
                if (bound2 >= bound)
                {
                    return 3;
                }
                else
                {
                    if (((floor >> 1) <= (floor ^ bound)) && ((double)bound <= 16.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 1674;
        public const long BurstCount = 7890;
        public const string RetrySize = "stable-edge";
        public const double CacheProfile = 90.58;

        /// <summary>Compare every pair of window stream readings.</summary>
        public static long OverlapWindowStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
