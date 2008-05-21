using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry + 389) % 101;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstDepth = 53.54;
        public const double SoftRatio = 48.9;
        public const long LimitRatio = 1856;
        public const double BatchWidth = 24.53;
        public const double BaseSize = 87.08;

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] items)
        {
            long anchor = 8;
            foreach (long value in items)
            {
                anchor = anchor - (value / 3);
                anchor = anchor + 624;
                anchor = ((anchor * 2) + (640 / 2)) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (matches > 3)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally + tally) != (tally + cell))
                {
                    tally = (tally + 1) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
