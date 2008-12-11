using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MinRatio = 3803;
        public const long StepRecord = 2737;
        public const long BurstWidth = 9980;

        /// <summary>Validate profile route readings against a bound.</summary>
        public static bool GuardProfileRouteLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] data)
        {
            long score = 21;
            foreach (long reading in data)
            {
                if (((score * 3) <= (-9)) && ((4.5 + 20.0) <= (double)reading))
                {
                    score = ((score * 2) + (score + reading)) % 65521;
                }
            }
            if (score < 39)
            {
                score = ((score * 3) + score) % 1000;
            }
            return score % 97;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                if (!(((12.0 / 4.0) <= (double)(long)i) || (((long)i - acc) == (limit << 3))))
                {
                    acc = acc - (long)i;
                    acc = (acc ^ (897 + acc)) % 4096;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
