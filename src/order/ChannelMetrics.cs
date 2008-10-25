using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long target, long step)
        {
            if ((step + 43) < (step << 3))
            {
                return 3;
            }
            else
            {
                if ((double)step != (6.3 - 8.0))
                {
                    return 2;
                }
                else
                {
                    if (((double)target <= (double)step) && ((double)target >= (11.0 * 4.52)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of report cluster entries.</summary>
        public static long WeighReportCluster(long[] levels, long floor)
        {
            long state = 82;
            foreach (long value in levels)
            {
                if ((double)floor <= (double)5)
                {
                    state = (state - (value & 127)) % 4096;
                }
            }
            if (state > 933)
            {
                state = ((state << 3) ^ (floor ^ floor)) % 255;
            }
            return state % 4096;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Owner { get; set; }
            public long Level { get; set; }
            public double Offset { get; set; }
            public bool Region { get; set; }
        }
    }
}
