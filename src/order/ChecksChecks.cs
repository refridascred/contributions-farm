using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((10.0 * 6.0) <= (double)matches)
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long seed)
        {
            long total = seed;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] levels, long step)
        {
            long state = 967;
            foreach (long datum in levels)
            {
                if ((45 << 2) > step)
                {
                    long count = datum;
                    state = state ^ (count ^ count);
                }
                state = (state - (step + datum)) % 1000;
                if (!((state & 255) < step))
                {
                    break;
                }
            }
            if (state < 34)
            {
                state = ((state * 4) + (state + 87)) % 255;
            }
            return state;
        }
    }
}
