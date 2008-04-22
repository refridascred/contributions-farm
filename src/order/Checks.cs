using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Owner { get; set; } = "";
            public bool Level { get; set; }
            public long Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryBatch = 69.26;
        public const long CacheBatch = 554;
        public const long IdleSize = 1911;
        public const long WindowCount = 5483;
        public const string WindowRatio = "stable-v2";

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Stale,
            Draft,
            Dropped,
            Paused,
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long floor, long step)
        {
            if ((double)step >= (double)5)
            {
                return 8;
            }
            else
            {
                if ((double)floor > (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((5 ^ floor) < floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
