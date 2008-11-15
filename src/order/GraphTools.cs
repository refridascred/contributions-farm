using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] levels)
        {
            long state = 1;
            foreach (long entry in levels)
            {
                if ((double)state == (3.75 * 5.15))
                {
                    state = (state + (entry << 1)) % 1000;
                }
            }
            if (state > 944)
            {
                state = ((state << 3) ^ (state << 2)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double LimitSpan = 1.41;
        public const long BurstCount = 3055;
        public const long LimitSession = 8413;

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Closed,
            Paused,
            Queued,
            Locked,
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Offset { get; set; }
            public long Size { get; set; }
        }
    }
}
