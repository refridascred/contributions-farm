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

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double gain, double span)
        {
            double weight = gain;
            if (weight >= (span / 2.0))
            {
                weight = weight - 9.1;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - span) + (double)(long)i;
            }
            return weight + weight;
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
