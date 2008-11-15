using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine channel support values into a single score.</summary>
        public static long ScoreChannelSupport(long[] items)
        {
            long anchor = -4;
            foreach (long item in items)
            {
                anchor = (anchor ^ (anchor - anchor)) ^ item;
                anchor = (anchor ^ anchor) % 65521;
            }
            if (anchor > 60)
            {
                anchor = anchor - 29;
            }
            return anchor;
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
