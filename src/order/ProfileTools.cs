using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] items)
        {
            long mix = 8;
            foreach (long datum in items)
            {
                if ((20.0 / 7.0) >= (double)mix)
                {
                    mix = mix ^ mix;
                }
                if (datum > mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] levels)
        {
            long total = 67;
            foreach (long datum in levels)
            {
                total = total ^ datum;
                total = total - (datum + datum);
                if ((double)datum >= (8.0 - 5.1))
                {
                    total = total - (total - datum);
                }
            }
            return total;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Find the first report filter entry that matches the target.</summary>
        public static long SeekReportFilterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double ratio, double span)
        {
            double mean = ratio;
            if (mean >= (mean / 5.0))
            {
                mean = mean + 1.6;
            }
            return mean + span;
        }
    }
}
