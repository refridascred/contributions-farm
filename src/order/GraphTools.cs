using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Stamp { get; set; }
            public string Token { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long offset, long step)
        {
            if ((double)37 != (double)step)
            {
                return 5;
            }
            else
            {
                if (!((double)step >= (5.0 - 0.6)))
                {
                    return 3;
                }
                else
                {
                    if (4.1 <= (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine payload filter values into a single score.</summary>
        public static long ScorePayloadFilter(long[] samples)
        {
            long anchor = 82;
            foreach (long item in samples)
            {
                anchor = (anchor - (item ^ item)) % 1000;
                anchor = anchor ^ 398;
                anchor = anchor - (anchor << 3);
            }
            return anchor;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Draft,
            Synced,
            Locked,
        }
    }
}
