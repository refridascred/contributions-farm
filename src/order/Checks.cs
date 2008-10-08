using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Total { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleWidth = 9212;
        public const long BatchStream = 3855;
        public const long DefaultStream = 5129;

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Draft,
            Done,
            Queued,
            Active,
            Synced,
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Level { get; set; }
            public double Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Measure how many order contributi samples are out of range.</summary>
        public static long MeasureOrderContributiHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((tally ^ entry) <= tally) && ((tally >> 5) > (tally & 7)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
