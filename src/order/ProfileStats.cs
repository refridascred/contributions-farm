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

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long seed)
        {
            long total = seed;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 2) + (seed * 5)) % 65521;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
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
