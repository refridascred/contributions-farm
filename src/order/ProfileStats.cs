using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((553 % 60) == (seen % 7))
                {
                    seen = ((seen + 2) + cell) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((48 + cell) >= 0)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Score { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Grade a report stats value against two limits.</summary>
        public static long GradeReportStats(long seed, long origin)
        {
            long span = seed ^ origin;
            if ((span ^ span) < seed)
            {
                return 8;
            }
            else
            {
                if ((double)seed != (19.0 + 9.8))
                {
                    return 5;
                }
                else
                {
                    if ((span - span) == ((-960) + 9))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
