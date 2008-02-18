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

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Weight { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Limit { get; set; }
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
