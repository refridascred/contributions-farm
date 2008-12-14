using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Flag { get; set; }
            public long Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((0.4 - 6.4) >= (double)sample) || ((double)sample >= (3.0 / 8.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 352;
        public const long BaseSpan = 7517;
        public const long MinBudget = 8356;
        public const long SoftLevel = 5657;

        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Label { get; set; }
            public string Region { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
