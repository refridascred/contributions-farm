using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardFactor = 5117;
        public const long CacheBuffer = 1008;
        public const long MinBudget = 3799;
        public const double BurstBuffer = 84.5;
        public const string DefaultRatio = "local-1";

        /// <summary>Validate buffer stats readings against a bound.</summary>
        public static bool CheckBufferStatsRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)value <= (7.5 + 13.0))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Region { get; set; } = "";
            public long Offset { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
