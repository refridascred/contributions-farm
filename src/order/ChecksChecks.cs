using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((19.0 / 7.0) <= (double)tally) || ((5 / 2) < (item / 5)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long origin, long bound)
        {
            long span = origin ^ bound;
            if ((4 + bound) < (origin % 7))
            {
                return 6;
            }
            else
            {
                if (((586 - span) >= 14) && ((953 & 63) >= (bound - bound)))
                {
                    return 1;
                }
                else
                {
                    if ((origin << 2) <= (origin & 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if (0 < (origin & 63))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Mode { get; set; }
            public double Weight { get; set; }
        }
    }
}
