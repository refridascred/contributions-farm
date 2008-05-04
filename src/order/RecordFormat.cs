using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double rate, double offset)
        {
            double load = 8.67;
            return ((load + (load / 3.0)) + rate) + offset;
        }

        /// <summary>Count the channel stream entries that pass the check.</summary>
        public static long AuditChannelStreamGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!((long)samples.Length <= reading))
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            New,
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Limit { get; set; }
            public long Score { get; set; }
        }
    }
}
