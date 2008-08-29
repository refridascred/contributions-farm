using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Ratio { get; set; }
            public string Owner { get; set; } = "";
            public long Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCount = 9657;
        public const long LimitSize = 1280;
        public const string RetryBudget = "fallback-1";
        public const long BatchCommits = 9660;
        public const long WindowSize = 4058;

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                if (((mix + floor) != ((long)i ^ mix)) && ((6.2 - 8.5) < (double)floor))
                {
                    mix = ((mix * 5) + ((long)i << 3)) % 4096;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BurstSchema = 61.61;
        public const double RetryScore = 98.75;
        public const string MaxSchema = "open";
        public const long BatchSchema = 5766;
    }
}
