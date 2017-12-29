using System;

namespace Common.Utilities
{
    /// <summary>Queue helpers helpers.</summary>
    public static class QueueHelpers
    {
        /// <summary>Wrap a record command index into a fixed-size ring.</summary>
        public static int WrapRecordCommandIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }

        /// <summary>Calculate a 16-bit checksum of a metric cursor key.</summary>
        public static int MetricCursorChecksum(string text)
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

        /// <summary>Calculate a 16-bit checksum of a filter key.</summary>
        public static int FilterChecksum(string text)
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

        /// <summary>Clamp a already value to a valid range.</summary>
        public static double ClampAlready(double value, double lo, double hi)
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
