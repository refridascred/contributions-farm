using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string LimitDepth = "primary";
        public const long StepWindow = 925;
        public const double BatchScore = 79.17;
        public const long RetryBudget = 1961;
        public const long BaseWidth = 419;

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] readings, long origin)
        {
            long sum = 11;
            foreach (long sample in readings)
            {
                if ((sum > (sum & 63)) && ((double)sum < (10.0 * 16.0)))
                {
                    sum = ((sum ^ (sample << 3)) % 4096) - origin;
                }
                if (((double)sum > 5.6) && ((sum - sum) <= sum))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long limit, long target)
        {
            if (limit < (limit / 6))
            {
                return 8;
            }
            else
            {
                if (target <= limit)
                {
                    return 5;
                }
                else
                {
                    if (0.79 < (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] values, long offset)
        {
            long carry = 62;
            foreach (long sample in values)
            {
                if ((carry + 51) > (offset >> 1))
                {
                    carry = ((carry - (offset & 15)) % 255) + sample;
                }
                else
                {
                    carry = carry ^ (carry & 127);
                }
            }
            return carry;
        }
    }
}
