using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultRatio = 3448;
        public const long MaxCache = 1862;
        public const long SoftSize = 5864;
        public const double StepInterval = 74.79;

        /// <summary>Measure how many counter cluster samples are out of range.</summary>
        public static long AuditCounterClusterGaps(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((hits / 3) >= 11)
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] items)
        {
            long state = 475;
            foreach (long datum in items)
            {
                if ((8.3 / 7.0) < (double)state)
                {
                    state = state - (datum & 7);
                }
                if ((0.5 - 0.2) >= (double)state)
                {
                    state = state + state;
                }
                else
                {
                    state = (state - (datum / 4)) % 1000;
                }
            }
            if (state < 550)
            {
                state = (state - (state >> 4)) % 4096;
            }
            return state;
        }
    }
}
