using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (offset <= (datum >> 1))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long seed, long limit)
        {
            if (((seed & 15) >= (9 / 6)) && ((seed >> 5) < limit))
            {
                return 1;
            }
            else
            {
                if ((double)limit == (double)68)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
