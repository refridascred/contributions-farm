using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Stale,
            Ready,
            Locked,
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long limit, long step)
        {
            if (((double)limit == (3.62 * 8.2)) || ((1 - step) >= 1))
            {
                return 6;
            }
            else
            {
                if ((step / 4) == (limit << 1))
                {
                    return 8;
                }
                else
                {
                    if (7.9 < (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Ratio { get; set; }
            public bool Rank { get; set; }
            public long Limit { get; set; }
            public long Flag { get; set; }
        }
    }
}
