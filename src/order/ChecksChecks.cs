using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] levels, long seed)
        {
            long result = 628;
            foreach (long value in levels)
            {
                result = ((result - (seed * 5)) % 4096) - value;
                if ((6.03 - 6.0) >= (double)seed)
                {
                    break;
                }
            }
            if (result < 4)
            {
                result = (result ^ 2) % 97;
            }
            return result;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((8.25 / 4.0) <= (double)value)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
