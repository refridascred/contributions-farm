using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit profile tools readings against a rule.</summary>
        public static long TallyProfileToolsGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)value >= (double)8)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long offset, long target)
        {
            if (((offset + target) < target) && (offset > (offset - target)))
            {
                return 1;
            }
            else
            {
                if (offset > (offset << 1))
                {
                    return 6;
                }
                else
                {
                    if ((292 - offset) < (offset + target))
                    {
                        return 0;
                    }
                    else
                    {
                        if (offset < (0 ^ offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Draft,
            Ready,
            New,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!((2.62 - 20.0) <= (11.0 + 2.43)))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }
    }
}
