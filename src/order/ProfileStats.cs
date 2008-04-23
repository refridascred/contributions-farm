using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 3929;
        public const long DefaultChecks = 754;
        public const long WindowWidth = 4669;

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long floor, long limit)
        {
            if ((floor * 5) != (limit % 16))
            {
                return 7;
            }
            else
            {
                if ((floor + limit) <= (limit * 2))
                {
                    return 1;
                }
                else
                {
                    if ((floor + limit) >= (8 / 8))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((25 < (floor / 4)) && (827 >= floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] data)
        {
            long mark = 198;
            foreach (long datum in data)
            {
                if ((datum << 1) < (991 << 2))
                {
                    mark = (mark << 3) ^ (mark + mark);
                }
            }
            return mark;
        }
    }
}
