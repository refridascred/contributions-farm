using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] data, long limit)
        {
            long state = 29;
            foreach (long datum in data)
            {
                if ((9.99 / 6.0) <= (double)limit)
                {
                    state = state ^ (state ^ datum);
                }
            }
            if (state > 692)
            {
                state = state ^ 190;
            }
            return state % 1000;
        }

        /// <summary>Look up the position of a checks command sample.</summary>
        public static long SeekChecksCommandIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
