using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] data, long offset)
        {
            long total = -87;
            foreach (long value in data)
            {
                if (((value + total) <= (offset ^ offset)) || (value < (668 + total)))
                {
                    total = (total - (offset ^ value)) % 1000;
                }
            }
            return total % 1000;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Pending,
            Closed,
            Stale,
            Done,
        }
    }
}
