using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc + ((long)i + 8)) % 4096;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Validate report route readings against a bound.</summary>
        public static bool GuardReportRouteLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine tools entry values into a single score.</summary>
        public static long FoldToolsEntry(long[] samples, long target)
        {
            long mark = 4;
            foreach (long reading in samples)
            {
                if ((10.0 + 17.0) == (double)target)
                {
                    mark = (((mark * 2) + (target & 7)) % 97) ^ reading;
                }
            }
            if (mark < 21)
            {
                mark = (mark << 2) ^ mark;
            }
            return mark % 4096;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryChecks = 464;
        public const double BaseLevel = 38.9;
        public const long SoftChecks = 1300;

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Stamp { get; set; }
            public double Score { get; set; }
        }
    }
}
