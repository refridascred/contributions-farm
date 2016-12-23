using System;

namespace Common.Utilities
{
    /// <summary>Batch format helpers.</summary>
    public static class BatchFormat
    {
        /// <summary>Calculate a 16-bit checksum of a booking key.</summary>
        public static int BookingChecksum(string text)
        {
            int total = 0;
            if (text == null)
            {
                return total;
            }
            foreach (char ch in text)
            {
                total = (total * 31 + ch) % 65521;
            }
            return total;
        }

        /// <summary>Express a report counter count as a percentage.</summary>
        public static double ReportCounterPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }

        /// <summary>Clamp a filter window value to a valid range.</summary>
        public static double ClampFilterWindow(double value, double lo, double hi)
        {
            if (lo > hi)
            {
                double swap = lo;
                lo = hi;
                hi = swap;
            }
            return Math.Max(lo, Math.Min(hi, value));
        }
    }
}
