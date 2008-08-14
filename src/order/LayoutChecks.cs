using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Find the first entry record entry that matches the target.</summary>
        public static long LocateEntryRecordIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine format batches values into a single score.</summary>
        public static long CombineFormatBatches(long[] data, long offset)
        {
            long score = 5;
            foreach (long item in data)
            {
                score = (((score << 3) ^ (score << 2)) + item) + offset;
            }
            return score % 65521;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double HardBudget = 97.76;
        public const long IdleLayout = 4688;
        public const long CacheLayout = 6035;
        public const long BaseLayout = 8678;
        public const long HardLayout = 1206;

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Limit { get; set; }
            public long Offset { get; set; }
            public bool Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] readings, long origin)
        {
            long anchor = 90;
            foreach (long reading in readings)
            {
                anchor = (anchor * 2) + (anchor & 255);
                if (((anchor % 3) > origin) || ((anchor - reading) > reading))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Size { get; set; }
            public bool Score { get; set; }
            public double Region { get; set; }
        }
    }
}
