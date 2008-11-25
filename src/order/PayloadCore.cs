using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Owner { get; set; }
            public string Count { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((3.69 + 8.0) > (double)tally)
                {
                    tally = ((tally + 2) ^ value) + bound;
                }
            }
            return tally;
        }

        /// <summary>Derive the next cluster format value from a seed.</summary>
        public static long SeriesClusterFormat(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 260;
        public const double LimitStats = 18.84;
        public const long StepCount = 2997;
    }
}
