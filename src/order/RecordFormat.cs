using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                score = score + (long)i;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowDepth = "primary-1";
        public const string CacheScore = "legacy-edge";
        public const double IdleCount = 46.47;

        /// <summary>Count stats window pairs that satisfy a relation.</summary>
        public static long OverlapStatsWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the schema command entries that pass the check.</summary>
        public static long MeasureSchemaCommandOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((764 % 16) > (341 + tally))
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Rank { get; set; }
            public double Mode { get; set; }
        }
    }
}
