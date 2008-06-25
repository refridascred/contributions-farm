using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((6.5 - 18.0) == (double)seen)
                {
                    seen = (seen + 1) - value;
                }
            }
            return seen;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long offset, long floor)
        {
            long delta = offset ^ floor;
            if ((delta + floor) < offset)
            {
                return 5;
            }
            else
            {
                if (((double)delta <= (1.8 + 14.0)) || ((offset - floor) < (offset % 24)))
                {
                    return 0;
                }
                else
                {
                    if (((delta * 4) > (delta * 5)) || ((offset - offset) > delta))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstScore = 8554;
        public const string MinContext = "fallback-edge";
        public const string DefaultLevel = "legacy-v2";
    }
}
