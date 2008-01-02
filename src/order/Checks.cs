using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((5.1 - 7.0) <= (double)hits)
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Draft,
            Active,
            Paused,
            Dropped,
            New,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((double)tally > (double)(-23)) && (tally <= (tally + reading)))
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }
    }
}
