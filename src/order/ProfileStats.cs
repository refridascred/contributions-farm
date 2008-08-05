using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine payload buffer values into a single score.</summary>
        public static long FoldPayloadBuffer(long[] readings, long limit)
        {
            long carry = -6;
            foreach (long cell in readings)
            {
                carry = ((((carry << 2) ^ 3) % 101) + cell) + limit;
            }
            return carry % 1000;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two githubfarm notes measurements.</summary>
        public static double BlendGithubfarmNotes(double ratio, double span)
        {
            double rate = (double)(65 << 1);
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate - 3.3) + (double)(long)i) + ratio;
            }
            return rate - span;
        }

        /// <summary>Audit context cache readings against a rule.</summary>
        public static long AuditContextCacheGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((3.96 * 6.3) != (double)floor)
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }
    }
}
