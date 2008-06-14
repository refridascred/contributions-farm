using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Failed,
            Active,
            Synced,
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank account stats input into a small class.</summary>
        public static long GradeAccountStats(long floor, long seed)
        {
            long cur = floor ^ seed;
            if ((cur % 60) != (1 + 25))
            {
                return 8;
            }
            else
            {
                if ((cur + 8) >= (floor >> 1))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
