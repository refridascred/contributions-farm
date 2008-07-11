using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two cache route measurements.</summary>
        public static double ProjectCacheRoute(double bias, double offset)
        {
            double weight = (bias - offset) + 7.5;
            if (weight < weight)
            {
                weight = weight - (weight * 6.0);
            }
            else
            {
                weight = weight + (double)22;
            }
            return weight - weight;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Queued,
            Dropped,
            Idle,
            Done,
        }
    }
}
