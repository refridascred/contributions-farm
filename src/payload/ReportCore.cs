using System;

namespace Common.Utilities
{
    /// <summary>Report core helpers.</summary>
    public static class ReportCore
    {
        /// <summary>Sum the squares of catalog queue samples.</summary>
        public static double CatalogQueueEnergy(double[] values)
        {
            double total = 0.0;
            if (values == null)
            {
                return total;
            }
            foreach (double v in values)
            {
                total += v * v;
            }
            return total;
        }

        /// <summary>Clamp a session value to a valid range.</summary>
        public static double ClampSession(double value, double lo, double hi)
        {
            if (lo > hi)
            {
                double swap = lo;
                lo = hi;
                hi = swap;
            }
            return Math.Max(lo, Math.Min(hi, value));
        }

        /// <summary>Wrap a record index into a fixed-size ring.</summary>
        public static int WrapRecordIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }
    }
}
