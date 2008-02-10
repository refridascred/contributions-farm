using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches >= (value << 3)) && ((value & 255) == (value + origin)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 4588;
        public const long CacheScore = 4494;
        public const long MinBatches = 7032;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 4744;
        public const long WindowTimeout = 8672;
        public const string WindowSchema = "staging";

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Limit { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
