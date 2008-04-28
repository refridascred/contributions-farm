using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next record session value from a seed.</summary>
        public static long StepRecordSession(long target)
        {
            long total = target;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double scale, double span)
        {
            double mean = (double)(62 ^ 13);
            if (mean < (double)(-439))
            {
                mean = mean + (scale + mean);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (double)26) + (double)(long)i;
            }
            return mean - (span * 4.12);
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
