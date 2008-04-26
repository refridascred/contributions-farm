using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample % 60) >= (sample ^ (long)items.Length))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((long)samples.Length >= reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double scale, double bias)
        {
            double scale2 = (double)((-3) >> 5);
            if (scale2 <= (scale + bias))
            {
                scale2 = scale2 - (bias - scale2);
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 - scale) + (double)(long)i;
            }
            return scale2 - scale2;
        }
    }
}
