using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first format order entry that matches the target.</summary>
        public static long SeekFormatOrderIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Token { get; set; }
            public long Owner { get; set; }
            public double Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Rank already checks input into a small class.</summary>
        public static long GradeAlreadyChecks(long target, long bound)
        {
            if ((bound + (-89)) < bound)
            {
                return 7;
            }
            else
            {
                if ((target - bound) > bound)
                {
                    return 6;
                }
                else
                {
                    if ((bound ^ target) <= (bound + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target + 39) == (target << 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
