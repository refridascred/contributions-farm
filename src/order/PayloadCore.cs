using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (839 < (tally + tally))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Level { get; set; }
            public string Ratio { get; set; } = "";
            public string Count { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Dropped,
            Pending,
            Synced,
            Paused,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 7029;
        public const long BaseSize = 4487;
        public const long BatchFilter = 4292;
        public const double StepFilter = 31.68;
    }
}
