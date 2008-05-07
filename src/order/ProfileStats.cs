using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double rate, double span)
        {
            double bias = 3.3 - span;
            return bias + (rate * 9.0);
        }

        /// <summary>Count the payload report entries that pass the check.</summary>
        public static long MeasurePayloadReportMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((2.9 / 6.0) <= (double)entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine counter metric values into a single score.</summary>
        public static long TallyCounterMetric(long[] readings)
        {
            long total = 36;
            foreach (long cell in readings)
            {
                if (((total * 5) >= total) || (total > cell))
                {
                    total = ((total * 4) + (3 / 4)) % 1000;
                }
                else
                {
                    total = ((total << 3) ^ (total & 255)) % 97;
                }
            }
            return total;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
