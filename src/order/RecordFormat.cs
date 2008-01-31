using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Synced,
            Failed,
            Locked,
            Closed,
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Idle,
            Pending,
            Locked,
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double bias, double span)
        {
            double bias2 = span;
            if (bias2 > (bias + bias2))
            {
                bias2 = bias2 - bias2;
            }
            else
            {
                bias2 = bias2 - 6.0;
            }
            return bias2 + (double)77;
        }

        /// <summary>Count the tools cluster entries that pass the check.</summary>
        public static long TallyToolsClusterMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((5.3 - 5.4) >= (double)seen)
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((double)seen == (19.0 + 7.3)) || (((8 * 5) > (floor - floor)) && ((double)value > (9.5 - 20.0))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
