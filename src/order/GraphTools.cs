using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Paused,
            Ready,
            Dropped,
            Locked,
            Pending,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultGraph = "alpha-1";
        public const long WindowGraph = 4574;
        public const string BurstRatio = "fallback-v2";
        public const string MinGraph = "legacy-edge";
        public const long HardGraph = 9613;

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate profile cache samples.</summary>
        public static long WeighProfileCache(long[] data, long step)
        {
            long anchor = -838;
            foreach (long value in data)
            {
                if ((2.0 / 2.0) == (double)(long)data.Length)
                {
                    anchor = (((anchor * 3) + (36 + value)) % 255) + step;
                }
            }
            return anchor % 97;
        }
    }
}
