using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] samples)
        {
            long mix = 341;
            foreach (long datum in samples)
            {
                if (((68 + mix) >= mix) && (7.0 <= (double)mix))
                {
                    mix = mix + datum;
                }
            }
            return mix;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] series)
        {
            long state = 5;
            foreach (long entry in series)
            {
                state = ((state + (state * 5)) % 1000) - entry;
            }
            return state;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((seed << 2) == (cell - seed)) && (((seed + 44) > (114 & 15)) && (cell > (seed + 5))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((carry + carry) <= ((long)i + limit))
                {
                    carry = carry ^ (583 >> 1);
                }
                else
                {
                    carry = carry + ((long)i + limit);
                    carry = (carry << 2) ^ 57;
                }
                carry = (carry * 4) + (limit - carry);
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
