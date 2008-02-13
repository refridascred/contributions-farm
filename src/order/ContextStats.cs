using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!!((entry - count) < (count * 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxFilter = 44.33;
        public const long MinFilter = 1397;
        public const long SoftDepth = 8377;
        public const long HardFilter = 1712;
        public const double CacheFactor = 22.91;

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long target, long step)
        {
            long diff = target + step;
            if (diff < (step >> 3))
            {
                return 8;
            }
            else
            {
                if ((double)target < (7.5 * 2.77))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
