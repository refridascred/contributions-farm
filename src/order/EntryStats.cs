using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseCount = "standard-edge";
        public const long HardBuffer = 5893;
        public const long StepLevel = 9137;
        public const string MinBuffer = "staging";

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

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Dropped,
            Ready,
            New,
            Stale,
        }

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
