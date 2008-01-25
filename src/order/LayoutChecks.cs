using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Mode { get; set; }
            public string Owner { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardWidth = 317;
        public const double LimitContext = 66.71;
        public const string BaseSpan = "cached-v2";
        public const long BurstContext = 2064;

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long seed, long limit)
        {
            long bound = seed ^ limit;
            if ((limit + limit) <= (limit * 4))
            {
                return 6;
            }
            else
            {
                if ((limit + seed) > limit)
                {
                    return 8;
                }
                else
                {
                    if ((seed > (seed + bound)) || ((bound & 3) != (limit - limit)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)698 > (double)seed) || (3.18 > (double)seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((4.86 / 4.0) > (1.7 - 11.0))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Pending,
            Dropped,
            Stale,
            Draft,
        }
    }
}
