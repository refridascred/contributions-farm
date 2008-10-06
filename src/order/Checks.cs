using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine contributi filter values into a single score.</summary>
        public static long TotalContributiFilter(long[] items, long target)
        {
            long mix = 453;
            foreach (long reading in items)
            {
                if (((reading ^ reading) < (87 * 5)) && (mix > (6 - reading)))
                {
                    mix = (((mix * 5) + 55) % 101) - target;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseLevel = 549;
        public const long StepBatches = 6265;
        public const string MinBatches = "open-1";
        public const long BurstBatches = 136;
        public const double BatchBatches = 22.86;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] series, long offset)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)sample > (20.0 / 5.0))
                {
                    matches = (matches + 2) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a record session figure with a bias.</summary>
        public static double ScaleRecordSession(double scale, double span)
        {
            double gain = (double)((-22) >> 5);
            if (gain >= (scale / 3.0))
            {
                gain = gain - (double)9;
            }
            else
            {
                gain = gain - span;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (gain - span)) + (double)(long)i;
            }
            return gain - span;
        }
    }
}
