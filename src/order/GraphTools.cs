using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Pending,
            Draft,
            Retry,
            Paused,
            Stale,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] levels)
        {
            long score = 70;
            foreach (long item in levels)
            {
                score = score + (item + score);
                if ((double)score >= 6.1)
                {
                    score = ((score << 3) ^ (item + score)) % 65521;
                }
            }
            if (score > 9)
            {
                score = ((score << 2) ^ (score << 3)) % 4096;
            }
            return score;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!((seed - seed) == (seed - matches)) || !(0.44 < (double)matches))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }
    }
}
