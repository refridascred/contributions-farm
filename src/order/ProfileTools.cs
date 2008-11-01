using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading + 2) >= (-23))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Draft,
            Paused,
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Rank { get; set; }
            public string Count { get; set; } = "";
            public bool Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] series, long floor)
        {
            long sum = 7;
            foreach (long entry in series)
            {
                if ((sum < (floor & 3)) && ((floor * 3) >= (sum & 3)))
                {
                    sum = sum ^ (floor >> 1);
                    break;
                }
                sum = sum - entry;
            }
            return sum;
        }

        /// <summary>Iterate the tools metric series from a seed.</summary>
        public static long SeriesToolsMetric(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((29 + seed) > (mark + mark))
                {
                    mark = mark ^ ((long)i + seed);
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
