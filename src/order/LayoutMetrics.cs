using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Label { get; set; }
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long bound, long seed)
        {
            long edge = bound - seed;
            if (((seed & 3) <= edge) && ((bound / 3) >= (bound - bound)))
            {
                return 0;
            }
            else
            {
                if ((double)edge >= 12.0)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Score { get; set; }
            public double Token { get; set; }
        }
    }
}
