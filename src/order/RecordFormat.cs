using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string BatchCount = "strict-v2";
        public const double SoftCount = 43.17;
        public const long IdleChannel = 9456;
        public const long IdleWidth = 9642;

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Score { get; set; } = "";
            public double Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long floor, long bound)
        {
            long lane = floor + bound;
            if ((double)bound >= 2.6)
            {
                return 4;
            }
            else
            {
                if ((double)lane == (7.2 * 5.0))
                {
                    return 2;
                }
                else
                {
                    if (((bound % 60) == (lane % 64)) && ((floor + lane) >= (floor ^ bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor + bound) == (bound + 0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the report token entries that pass the check.</summary>
        public static long CountReportTokenMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (entry > (24 >> 1))
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (matches < (floor + 621))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }
    }
}
