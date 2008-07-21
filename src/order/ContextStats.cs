using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a record editor reading by value.</summary>
        public static long LookupRecordEditorIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
