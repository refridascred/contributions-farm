using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Size { get; set; }
            public double Offset { get; set; }
            public bool Owner { get; set; }
            public long Ratio { get; set; }
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
