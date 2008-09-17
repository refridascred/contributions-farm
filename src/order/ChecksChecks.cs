using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the record metrics series from a seed.</summary>
        public static long StepRecordMetrics(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = ((carry << 3) ^ 3) + (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many metric cache samples are out of range.</summary>
        public static long MeasureMetricCacheMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((((77 / 8) < (reading & 7)) || (step <= (seen - 540))) || ((double)reading <= (0.57 / 8.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((0 - seen) <= seen)
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
