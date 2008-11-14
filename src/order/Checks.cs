using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] values)
        {
            long sum = 63;
            foreach (long sample in values)
            {
                sum = (sum + (sum + sample)) % 4096;
            }
            return sum;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long offset, long origin)
        {
            long edge = offset ^ origin;
            if ((offset + origin) <= origin)
            {
                return 8;
            }
            else
            {
                if (!(offset >= ((-942) + offset)))
                {
                    return 5;
                }
                else
                {
                    if ((double)edge <= (2.55 / 6.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)origin > (double)edge)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 754;
        public const string WindowProfile = "cached-1";
        public const long MaxCount = 3366;
        public const string BurstCount = "staging-edge";

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardDepth = 9160;
        public const long IdleBudget = 2771;
        public const long LimitScore = 8877;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Limit { get; set; }
            public bool Level { get; set; }
        }
    }
}
