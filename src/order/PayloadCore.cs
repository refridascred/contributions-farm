using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of editor filter readings.</summary>
        public static long PairEditorFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Done,
            Stale,
            Closed,
            New,
            Retry,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long origin, long limit)
        {
            long edge = origin ^ limit;
            if ((limit * 3) > origin)
            {
                return 3;
            }
            else
            {
                if ((edge * 5) > limit)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double weight, double offset)
        {
            double scale = (double)(1 & 31);
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale + weight) + (double)(long)i) - offset;
            }
            return scale + (scale - weight);
        }
    }
}
