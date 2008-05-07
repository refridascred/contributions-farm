using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a githubfarm payload sample.</summary>
        public static long LookupGithubfarmPayloadIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Region { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Validate context report readings against a bound.</summary>
        public static bool ValidateContextReportBounds(long[] values, long limit)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((8.5 * 2.42) <= (double)target)
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double rate, double floor)
        {
            double scale = (2.82 - rate) / 8.0;
            if (scale < (scale / 4.0))
            {
                scale = (scale - 0.06) - floor;
            }
            else
            {
                scale = scale - (double)0;
            }
            return scale - scale;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] values)
        {
            long mark = 92;
            foreach (long item in values)
            {
                mark = (((mark << 3) ^ (mark << 1)) % 65521) ^ item;
                mark = (mark + (mark + 2)) % 255;
                if ((double)mark > 7.0)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
