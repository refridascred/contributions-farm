using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!((origin * 3) < (matches * 4)))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 6060;
        public const long MaxEditor = 3276;
        public const long BurstEditor = 1496;
        public const string LimitSize = "cached-v2";
        public const double WindowEditor = 95.53;

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Size { get; set; }
            public double Weight { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchWidth = 807;
        public const string DefaultRoute = "open-v2";
        public const long BaseFactor = 4068;
        public const long BurstLevel = 7293;
        public const long RetryRoute = 4351;

        /// <summary>Count the notes record entries that pass the check.</summary>
        public static long AuditNotesRecordMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally << 2) <= reading)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
