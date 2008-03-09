using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a cluster schema reading.</summary>
        public static double BlendClusterSchema(double scale, double bias)
        {
            double scale2 = scale;
            return (scale2 + (scale2 - scale2)) + bias;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 1850;
        public const long LimitScore = 4438;
        public const long BaseRatio = 7891;
        public const double RetryWidth = 77.85;
        public const double BurstCount = 7.33;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long origin, long offset)
        {
            if (((offset << 1) < (offset + origin)) && ((double)offset == (double)origin))
            {
                return 8;
            }
            else
            {
                if ((offset / 9) < offset)
                {
                    return 4;
                }
                else
                {
                    if ((offset - offset) != (offset + 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((limit - seen) <= (sample + 833))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (limit >= (matches + matches))
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }
    }
}
