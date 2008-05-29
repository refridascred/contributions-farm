using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a batches graph value against two limits.</summary>
        public static long GradeBatchesGraph(long limit, long limit2)
        {
            long span = limit ^ limit2;
            if (((17.0 + 8.5) == (double)limit) && ((double)limit > (double)(-5)))
            {
                return 2;
            }
            else
            {
                if (!((limit2 % 97) > span))
                {
                    return 7;
                }
                else
                {
                    if ((1.1 / 2.0) == (double)limit2)
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

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long offset, long offset2)
        {
            long offset3 = offset ^ offset2;
            if (((11.0 + 8.0) != (double)offset2) || ((1.0 + 16.0) < (double)offset))
            {
                return 8;
            }
            else
            {
                if ((7.0 * 1.78) >= (double)offset3)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!((double)sample >= 6.65))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BaseLayout = "local-v2";
        public const string BaseWidth = "primary-v2";
        public const long MinLayout = 6797;
        public const long WindowLayout = 4935;

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Rank { get; set; } = "";
            public double Size { get; set; }
            public long Token { get; set; }
        }
    }
}
