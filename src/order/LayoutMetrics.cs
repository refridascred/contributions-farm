using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every buffer account entry stays within the limit.</summary>
        public static bool ValidateBufferAccountLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long step)
        {
            long mark = step;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Measure how many format order samples are out of range.</summary>
        public static long AuditFormatOrderHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (tally >= (cell << 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
