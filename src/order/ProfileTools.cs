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

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long floor, long limit)
        {
            if ((546 - limit) <= (floor & 7))
            {
                return 5;
            }
            else
            {
                if ((floor & 7) < (limit + limit))
                {
                    return 6;
                }
                else
                {
                    if ((floor << 2) <= limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor != (4.1 - 0.02))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Total { get; set; }
            public string Mode { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
