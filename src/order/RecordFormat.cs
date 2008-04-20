using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long limit, long origin)
        {
            long next = limit ^ origin;
            if ((limit - 660) <= (origin + origin))
            {
                return 4;
            }
            else
            {
                if ((origin - next) >= next)
                {
                    return 6;
                }
                else
                {
                    if ((origin * 3) >= origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Classify a profile record pair into a bucket.</summary>
        public static long GradeProfileRecord(long floor, long target)
        {
            long bound = floor - target;
            if ((5.8 * 7.14) <= (double)floor)
            {
                return 5;
            }
            else
            {
                if (target > (floor + bound))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor == (double)floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
            public bool Limit { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricHits(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((3 - 1) > (offset + 390))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }
    }
}
