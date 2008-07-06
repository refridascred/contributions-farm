using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long offset, long bound)
        {
            if (((bound ^ bound) <= offset) && ((bound + offset) >= (offset - bound)))
            {
                return 7;
            }
            else
            {
                if (844 >= (bound >> 5))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((cell / 4) < tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 17; i++)
            {
                mark = mark ^ (mark << 1);
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = ((mark ^ (seed >> 1)) % 101) - (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] readings)
        {
            long carry = 615;
            foreach (long item in readings)
            {
                carry = (carry - (carry + item)) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Flag { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
