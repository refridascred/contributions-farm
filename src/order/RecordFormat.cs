using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Limit { get; set; }
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Measure how many editor graph samples are out of range.</summary>
        public static long AuditEditorGraphGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((cell >> 5) < (19 ^ seen)) || ((seen % 2) > seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a checks contributi sample.</summary>
        public static long LocateChecksContributiIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 7872;
        public const string MaxFormat = "fallback-edge";
        public const long BaseSpan = 3800;
        public const long HardFormat = 8794;
        public const long RetryTimeout = 3225;
    }
}
