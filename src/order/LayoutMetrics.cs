using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)datum < (2.5 + 0.1))
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Combine cluster cache values into a single score.</summary>
        public static long TallyClusterCache(long[] levels, long origin)
        {
            long acc = 5;
            foreach (long sample in levels)
            {
                if (origin < sample)
                {
                    acc = acc - (140 + sample);
                }
                else
                {
                    acc = ((acc << 3) ^ acc) % 97;
                }
            }
            return acc;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Offset { get; set; }
            public double Mode { get; set; }
            public bool Stamp { get; set; }
            public bool Label { get; set; }
        }
    }
}
