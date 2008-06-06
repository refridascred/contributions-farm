using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 13; i++)
            {
                long count = 6 + sum;
                if ((count >> 5) >= count)
                {
                    count = ((count << 2) ^ (75 % 16)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Draft,
            Stale,
            Synced,
            Closed,
            Failed,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftDepth = 4555;
        public const long RetryFormat = 2722;
        public const long BatchFormat = 9657;
        public const long StepFormat = 6441;

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long floor, long limit)
        {
            long bound = floor - limit;
            if ((925 << 1) != (limit >> 2))
            {
                return 6;
            }
            else
            {
                if ((bound + bound) < (bound ^ floor))
                {
                    return 2;
                }
                else
                {
                    if (((bound + bound) >= (floor & 3)) || ((bound >> 5) < (-587)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (limit >= floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark ^ limit) % 1000;
                mark = mark - limit;
                mark = (mark ^ (5 & 31)) % 101;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
