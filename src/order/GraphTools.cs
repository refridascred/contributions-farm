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

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] values, long target)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((56 ^ target) < (773 % 5))
                {
                    matches = (matches + 2) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
