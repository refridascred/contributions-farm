using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long origin, long target)
        {
            if ((target & 3) > (origin >> 2))
            {
                return 7;
            }
            else
            {
                if (((target & 127) > origin) || ((731 / 2) < target))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Retry,
            Paused,
            Failed,
            Done,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)seen != (10.0 + 5.8))
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }

        /// <summary>Derive the next channel metrics value from a seed.</summary>
        public static long DeriveChannelMetrics(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i + mark) <= (mark + mark))
                {
                    mark = mark ^ mark;
                }
                mark = (mark ^ (mark ^ bound)) % 97;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
