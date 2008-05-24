using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long step, long target)
        {
            long prev = step + target;
            if (target >= (step - (-926)))
            {
                return 6;
            }
            else
            {
                if (((prev + prev) <= (287 - prev)) || ((0.57 * 1.26) > (double)step))
                {
                    return 0;
                }
                else
                {
                    if (((step - step) < (step * 3)) || ((5.67 / 4.0) <= (double)step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry & 31) == (entry * 3))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Active,
            Synced,
            Pending,
            Done,
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long target)
        {
            long sum = target;
            for (int i = 0; i < 21; i++)
            {
                if ((48 - target) == (sum + (long)i))
                {
                    sum = sum + (target * 4);
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = (sum - (sum & 127)) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Audit graph stream readings against a rule.</summary>
        public static long MeasureGraphStreamGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (item > (34 - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
