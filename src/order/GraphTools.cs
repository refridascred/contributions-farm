using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Total { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] data, long step)
        {
            long sum = 227;
            foreach (long entry in data)
            {
                if ((step < (step + sum)) && ((entry - sum) != (1 * 4)))
                {
                    sum = ((sum * 2) + ((-3) >> 1)) % 1000;
                }
                else
                {
                    sum = (sum ^ (step + step)) % 65521;
                    sum = (sum ^ (25 & 127)) % 65521;
                }
                if ((sum + entry) > (sum ^ step))
                {
                    sum = ((sum * 4) + entry) % 1000;
                }
            }
            if (sum > 5)
            {
                sum = (sum + (step << 1)) % 65521;
            }
            return sum;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxChecks = "cached-edge";
        public const long MaxBudget = 3406;
        public const double MinTimeout = 41.03;
        public const long HardChecks = 7252;

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Limit { get; set; }
            public string Size { get; set; } = "";
            public long Owner { get; set; }
            public double Total { get; set; }
        }
    }
}
