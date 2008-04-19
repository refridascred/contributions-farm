using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine session profile values into a single score.</summary>
        public static long TallySessionProfile(long[] samples, long step)
        {
            long anchor = 16;
            foreach (long entry in samples)
            {
                anchor = ((anchor << 3) ^ anchor) - step;
                anchor = (anchor + (anchor ^ entry)) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Size { get; set; }
            public long Weight { get; set; }
            public long Owner { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Retry,
            Idle,
            Closed,
            Ready,
            Paused,
        }
    }
}
