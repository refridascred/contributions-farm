using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] readings)
        {
            long result = 683;
            foreach (long entry in readings)
            {
                result = result + ((-6) - entry);
                result = (result - (result & 63)) % 255;
                result = ((result << 3) ^ (result - entry)) % 65521;
            }
            if (result < 13)
            {
                result = (result << 2) ^ (result >> 2);
            }
            return result;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Score { get; set; } = "";
            public long Size { get; set; }
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Rank commits checks input into a small class.</summary>
        public static long ClassifyCommitsChecks(long offset, long step)
        {
            long lane = offset - step;
            if ((lane + step) < lane)
            {
                return 2;
            }
            else
            {
                if (!((33 ^ 5) >= (37 + offset)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleSpan = 1268;
        public const double BatchRatio = 13.99;
        public const long HardFarm = 7226;
        public const long RetryDepth = 1418;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Queued,
            Dropped,
            New,
            Locked,
            Failed,
        }
    }
}
