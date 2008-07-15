using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (limit < sample)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long bound, long step)
        {
            long diff = bound ^ step;
            if ((-8) < (step >> 5))
            {
                return 0;
            }
            else
            {
                if ((bound + step) == (diff - diff))
                {
                    return 2;
                }
                else
                {
                    if ((double)869 == (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double IdleSize = 26.04;
        public const long BatchBuffer = 5033;
        public const double SoftLevel = 27.9;
        public const long HardBuffer = 9278;

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] data, long seed)
        {
            long carry = -746;
            foreach (long item in data)
            {
                carry = (((carry + (12 * 3)) % 97) ^ item) + seed;
            }
            return carry;
        }
    }
}
