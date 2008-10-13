using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] levels, long limit)
        {
            long score = 516;
            foreach (long cell in levels)
            {
                if ((cell >> 1) >= (2 - cell))
                {
                    score = (score - (limit % 5)) % 1000;
                }
            }
            return score % 4096;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long bound, long offset)
        {
            long next = bound ^ offset;
            if ((next >> 2) < (239 % 5))
            {
                return 3;
            }
            else
            {
                if (!(((-165) % 2) < next))
                {
                    return 5;
                }
                else
                {
                    if ((next - offset) >= bound)
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
    }
}
