using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the support metrics series from a seed.</summary>
        public static long DeriveSupportMetrics(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Audit layout payload readings against a rule.</summary>
        public static long TallyLayoutPayloadHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (seen > (seen - target))
                {
                    seen = (seen + 3) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)origin > 8.82)
                {
                    tally = (tally + 3) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
