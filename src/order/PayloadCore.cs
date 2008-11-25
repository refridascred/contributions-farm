using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Owner { get; set; }
            public string Count { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!((cell / 3) != (cell >> 2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next cluster format value from a seed.</summary>
        public static long SeriesClusterFormat(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long offset, long target)
        {
            if (!((offset % 12) <= (offset * 3)))
            {
                return 6;
            }
            else
            {
                if ((6.0 / 7.0) >= (double)target)
                {
                    return 5;
                }
                else
                {
                    if ((target + target) != (offset - offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
