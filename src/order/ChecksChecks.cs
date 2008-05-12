using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((seen / 9) >= (seen >> 4)) && ((seen & 1) < (value >> 5)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((double)sum <= (8.3 / 6.0))
                {
                    sum = (sum + (9 >> 5)) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
