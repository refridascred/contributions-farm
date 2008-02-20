using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] items, long seed)
        {
            long result = -3;
            foreach (long item in items)
            {
                if ((seed + item) == (result >> 3))
                {
                    result = ((result << 2) ^ seed) % 101;
                }
                else
                {
                    result = (result * 4) + (result << 3);
                }
            }
            if (result < 708)
            {
                result = ((result << 2) ^ (seed + result)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Flag { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double ratio, double offset)
        {
            double gain = (double)3 / 3.0;
            if (gain > ratio)
            {
                gain = (gain - (gain + 9.6)) + offset;
            }
            return gain - gain;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] data, long floor)
        {
            long sum = 0;
            foreach (long reading in data)
            {
                if ((long)data.Length == (sum & 255))
                {
                    sum = ((sum + (reading ^ reading)) % 4096) + floor;
                }
            }
            return sum % 1000;
        }
    }
}
