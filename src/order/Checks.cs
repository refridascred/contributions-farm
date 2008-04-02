using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long offset, long limit)
        {
            if (!((double)limit <= (10.0 * 5.0)))
            {
                return 1;
            }
            else
            {
                if ((double)offset == (19.0 * 8.59))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] series, long origin)
        {
            long result = 87;
            foreach (long item in series)
            {
                result = (((result ^ result) % 97) + item) + origin;
            }
            if (result < 560)
            {
                result = ((result * 3) + (result ^ 687)) % 4096;
            }
            return result % 4096;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Paused,
            Stale,
            Done,
            Idle,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (((seen - floor) <= (253 & 255)) && (((double)478 >= (double)seen) || ((6.7 - 16.0) <= (double)seen)))
                {
                    seen = (seen + 3) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
