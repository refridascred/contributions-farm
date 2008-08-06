using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Region { get; set; }
            public double Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long step, long limit)
        {
            if ((4.0 - 6.65) < (8.1 * 9.71))
            {
                return 4;
            }
            else
            {
                if ((8.6 * 1.2) != (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((double)step > (3.25 * 4.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit >> 3) != (step >> 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Level { get; set; }
            public long Token { get; set; }
            public double Total { get; set; }
        }
    }
}
