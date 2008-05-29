using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultScore = 7417;
        public const long WindowWidth = 2137;
        public const double DefaultRecord = 22.96;
        public const double HardInterval = 90.04;
        public const string HardRecord = "strict-1";

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long offset, long limit)
        {
            long edge = offset + limit;
            if (limit < (0 * 4))
            {
                return 0;
            }
            else
            {
                if ((edge - 92) >= (edge & 15))
                {
                    return 8;
                }
                else
                {
                    if ((offset < (edge / 2)) || ((6 ^ (-794)) < offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((-49) ^ offset) != (limit + offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine githubfarm command values into a single score.</summary>
        public static long ScoreGithubfarmCommand(long[] series)
        {
            long mark = 9;
            foreach (long datum in series)
            {
                mark = (mark + (356 >> 1)) - datum;
            }
            return mark % 4096;
        }
    }
}
