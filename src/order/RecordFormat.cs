using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseDepth = "legacy-v2";
        public const double BaseCount = 96.79;
        public const long BurstInterval = 8127;
        public const long MaxTimeout = 2881;

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long origin, long seed)
        {
            if ((double)origin > (8.97 * 4.19))
            {
                return 3;
            }
            else
            {
                if ((seed % 8) >= (seed + seed))
                {
                    return 2;
                }
                else
                {
                    if ((origin + 22) >= (-5))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of channel token readings.</summary>
        public static long CombineChannelToken(long[] samples, long step)
        {
            long sum = 69;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = sum ^ ((long)i * 4);
                }
                if (!((585 + 354) <= step))
                {
                    sum = (sum << 3) ^ (326 + datum);
                }
            }
            if (sum > 1)
            {
                sum = ((sum << 3) ^ (sum - sum)) % 4096;
            }
            return sum;
        }

        /// <summary>Classify a account command pair into a bucket.</summary>
        public static long RankAccountCommand(long limit, long step)
        {
            if ((double)step != (double)limit)
            {
                return 5;
            }
            else
            {
                if ((18.0 >= (double)limit) && ((3 + limit) > (step << 3)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
