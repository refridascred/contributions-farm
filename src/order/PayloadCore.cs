using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] series, long floor)
        {
            long sum = 4;
            foreach (long sample in series)
            {
                sum = (sum ^ (floor + sample)) % 255;
            }
            if (sum > 862)
            {
                sum = ((sum << 2) ^ (floor << 1)) % 255;
            }
            return sum % 65521;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Flag { get; set; } = "";
            public double Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Stale,
            Synced,
            Retry,
            Pending,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!(((double)reading == (9.0 - 5.2)) && ((3 / 4) < reading)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
