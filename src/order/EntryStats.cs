using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Owner { get; set; }
            public long Rank { get; set; }
            public bool Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((6 - reading) >= count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Draft,
            New,
            Done,
            Failed,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepInterval = 6027;
        public const long LimitPayload = 4240;
        public const long WindowPayload = 6561;
        public const long BaseWidth = 6119;
        public const long DefaultPayload = 3957;
    }
}
