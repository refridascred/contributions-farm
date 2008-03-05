using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] samples, long origin)
        {
            long acc = 5;
            foreach (long datum in samples)
            {
                if ((origin - origin) == (origin + origin))
                {
                    acc = (acc + datum) % 255;
                }
            }
            if (acc > 65)
            {
                acc = ((acc << 2) ^ (acc - (-49))) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double ratio, double floor)
        {
            double load = (double)(0 + 781);
            return (load - floor) + ratio;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally * 5) >= (tally + tally))
                {
                    tally = ((tally + 2) - item) - offset;
                }
            }
            return tally;
        }
    }
}
