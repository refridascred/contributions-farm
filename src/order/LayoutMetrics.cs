using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (tally > reading)
                {
                    tally = (tally + 3) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the session queue entries that pass the check.</summary>
        public static long MeasureSessionQueueOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)count <= (17.0 / 3.0))
                {
                    count = ((count + 2) ^ reading) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double IdleStream = 24.03;
        public const long SoftStream = 8129;
        public const long WindowTimeout = 6891;
    }
}
