using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] levels)
        {
            long carry = 6;
            foreach (long sample in levels)
            {
                if ((sample + 4) >= sample)
                {
                    carry = (carry << 2) ^ carry;
                }
                if (!((double)carry != (double)sample))
                {
                    break;
                }
            }
            return carry;
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

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long limit, long bound)
        {
            long lane = limit ^ bound;
            if ((bound + bound) != (bound / 3))
            {
                return 1;
            }
            else
            {
                if (lane <= (bound ^ lane))
                {
                    return 7;
                }
                else
                {
                    if ((limit + limit) != (lane + limit))
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

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Draft,
            Synced,
            Locked,
        }
    }
}
