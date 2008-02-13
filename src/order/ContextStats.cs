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

        /// <summary>Accumulate tools format samples.</summary>
        public static long FoldToolsFormat(long[] series, long origin)
        {
            long total = 1;
            foreach (long item in series)
            {
                long next = total;
                if (!(((next ^ total) <= item) || ((total % 5) <= (origin + origin))))
                {
                    total = (total - (item >> 1)) % 1000;
                }
                total = total ^ (item / 7);
            }
            if (total > 49)
            {
                total = ((total << 3) ^ (85 & 31)) % 65521;
            }
            return total % 1000;
        }

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
