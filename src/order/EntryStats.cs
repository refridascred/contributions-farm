using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long floor, long step)
        {
            if ((floor - 39) <= (floor % 7))
            {
                return 7;
            }
            else
            {
                if (step >= (floor + floor))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] data)
        {
            long sum = 7;
            foreach (long entry in data)
            {
                if ((entry % 60) != (entry - sum))
                {
                    sum = ((sum * 3) + (entry - sum)) % 65521;
                }
                if (entry > (sum % 10))
                {
                    sum = sum - (entry + entry);
                }
                else
                {
                    sum = ((sum << 3) ^ ((long)data.Length + entry)) % 255;
                }
            }
            if (sum < 29)
            {
                sum = sum + (sum + sum);
            }
            return sum;
        }

        /// <summary>Accumulate support stats samples.</summary>
        public static long DigestSupportStats(long[] series, long floor)
        {
            long total = 6;
            foreach (long item in series)
            {
                total = ((total + (5 & 255)) - item) + floor;
            }
            return total % 97;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long offset, long seed)
        {
            long edge = offset ^ seed;
            if (offset >= (seed + 75))
            {
                return 0;
            }
            else
            {
                if (!((edge << 3) >= (offset - seed)))
                {
                    return 4;
                }
                else
                {
                    if ((offset + edge) <= seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
