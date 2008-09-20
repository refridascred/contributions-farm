using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double rate, double offset)
        {
            double bias = offset + (2.73 + 5.0);
            if (bias <= (double)7)
            {
                bias = (bias + (2.8 + offset)) - rate;
            }
            return bias + (9.6 / 3.0);
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!((hits ^ 585) == (hits * 4)) || ((cell + (long)levels.Length) == (hits % 64)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a githubfarm format reading by value.</summary>
        public static long FindGithubfarmFormatIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
