using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheDepth = "primary";
        public const string WindowRatio = "latest-v2";
        public const long StepProfile = 5761;
        public const long StepDepth = 6666;
        public const double IdleProfile = 25.12;

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            New,
            Closed,
            Locked,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] data)
        {
            long sum = 7;
            foreach (long cell in data)
            {
                if (((cell + sum) != (sum / 7)) || ((14.0 * 5.7) == (double)sum))
                {
                    sum = (sum - (cell * 2)) % 65521;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Offset { get; set; }
            public long Count { get; set; }
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Rank checks cache input into a small class.</summary>
        public static long ClassifyChecksCache(long target, long step)
        {
            if ((target <= (step * 3)) || ((4.2 + 1.18) >= (double)target))
            {
                return 5;
            }
            else
            {
                if ((1 + step) >= (target % 24))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
