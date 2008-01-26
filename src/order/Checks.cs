using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((3.0 / 2.0) < (double)offset)
                {
                    tally = (tally + 1) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next support channel value from a seed.</summary>
        public static long RollSupportChannel(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Rank { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstCommand = "standard-v2";
        public const long DefaultDepth = 3705;
        public const string MaxCommand = "primary";

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value >> 4) < value)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
