using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] values)
        {
            long carry = 86;
            foreach (long reading in values)
            {
                if ((reading << 3) >= (reading >> 2))
                {
                    carry = (carry - (7 & 7)) % 101;
                    carry = (carry ^ (reading - carry)) % 1000;
                }
                if ((carry / 6) >= (carry >> 5))
                {
                    carry = (carry << 2) ^ (reading & 1);
                }
            }
            return carry % 65521;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long floor, long limit)
        {
            long delta = floor ^ limit;
            if (((double)limit >= 14.0) || ((floor + delta) >= limit))
            {
                return 3;
            }
            else
            {
                if ((limit + delta) > (floor >> 4))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count order entry pairs that satisfy a relation.</summary>
        public static long OverlapOrderEntryCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
