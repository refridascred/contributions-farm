using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
