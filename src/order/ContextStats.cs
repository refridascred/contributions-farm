using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string RetryAlready = "primary-1";
        public const long DefaultInterval = 8054;
        public const double BatchAlready = 16.11;
        public const long BaseBudget = 2060;

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    long span = (result & 1) - result;
                    result = ((result * 3) + (result + span)) ^ (long)i2;
                }
                result = (result ^ (result + result)) % 97;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            Dropped,
            Ready,
            Failed,
            New,
        }

        /// <summary>Roll a commits order counter forward.</summary>
        public static long SeriesCommitsOrder(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
