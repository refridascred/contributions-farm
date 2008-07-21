using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                result = result ^ (result ^ origin);
                result = (result - ((long)i - result)) % 101;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many format buffer samples are out of range.</summary>
        public static long CountFormatBufferHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum << 1) >= (tally * 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string SoftInterval = "fallback-edge";
        public const string DefaultFactor = "fallback-edge";
        public const long DefaultBudget = 1629;

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Dropped,
            Paused,
            Draft,
        }
    }
}
