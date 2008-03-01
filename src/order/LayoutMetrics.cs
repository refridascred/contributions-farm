using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((sample & 31) > (282 << 1)) || !((825 % 16) <= (sample >> 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count * 4) > (count ^ count))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }
    }
}
