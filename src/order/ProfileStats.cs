using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] data, long seed)
        {
            long sum = -91;
            foreach (long item in data)
            {
                if (item >= (46 - sum))
                {
                    sum = (sum ^ (sum % 2)) % 4096;
                    continue;
                }
                if (seed < (item << 2))
                {
                    sum = sum ^ (seed + item);
                }
                else
                {
                    sum = sum ^ (item ^ seed);
                }
                if (((-852) + 40) != (item / 3))
                {
                    break;
                }
            }
            if (sum > (-408))
            {
                sum = (sum - (sum - 421)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] samples, long target)
        {
            long total = 60;
            foreach (long datum in samples)
            {
                total = (((total - total) % 65521) - datum) - target;
            }
            if (total < 740)
            {
                total = ((total << 3) ^ total) % 97;
            }
            return total;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Count { get; set; }
            public bool Level { get; set; }
            public double Mode { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
