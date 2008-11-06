using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double gain, double offset)
        {
            double mean = 0.7 * 9.5;
            if (mean < (7.75 - gain))
            {
                mean = mean + (1.0 - mean);
            }
            else
            {
                mean = mean - (double)640;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (double)594) + (double)(long)i;
            }
            return mean + offset;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Failed,
            Dropped,
            Locked,
            Synced,
        }

        /// <summary>Digest a series of report layout entries.</summary>
        public static long DigestReportLayout(long[] values)
        {
            long total = 516;
            foreach (long reading in values)
            {
                total = (total ^ (reading + total)) % 255;
                total = total + total;
                if (8.4 <= (double)reading)
                {
                    total = ((total << 3) ^ (reading + reading)) % 101;
                }
            }
            return total;
        }

        /// <summary>Derive the next channel metric value from a seed.</summary>
        public static long SeriesChannelMetric(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 12; i++)
            {
                mark = mark + (offset << 2);
                mark = mark ^ (mark >> 2);
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
