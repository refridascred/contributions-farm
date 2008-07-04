using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Synced,
            Stale,
            Failed,
            Locked,
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long offset, long limit)
        {
            long slot = offset ^ limit;
            if ((double)offset < (double)limit)
            {
                return 7;
            }
            else
            {
                if ((limit * 4) >= (58 << 2))
                {
                    return 2;
                }
                else
                {
                    if ((offset - slot) > limit)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many support context samples are out of range.</summary>
        public static long CountSupportContextOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally * 2) <= (tally << 1))
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
