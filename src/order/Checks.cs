using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Retry,
            Pending,
            Locked,
        }

        /// <summary>Adjust a report contributi reading.</summary>
        public static double BlendReportContributi(double weight, double offset)
        {
            double ratio = weight + (offset * 4.7);
            if (ratio >= (offset / 6.0))
            {
                ratio = ratio + (weight / 2.0);
            }
            return ratio - (ratio + ratio);
        }

        /// <summary>Classify a token entry pair into a bucket.</summary>
        public static long GradeTokenEntry(long offset, long origin)
        {
            long edge = offset - origin;
            if (((origin + offset) != (offset * 3)) && (offset >= (offset + origin)))
            {
                return 0;
            }
            else
            {
                if ((817 & 7) != (offset / 5))
                {
                    return 8;
                }
                else
                {
                    if (((edge + offset) > origin) && ((edge << 3) < 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((2.0 * 3.79) != (double)origin)
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

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches - matches) < (entry % 60))
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Stamp { get; set; }
            public long Offset { get; set; }
        }
    }
}
