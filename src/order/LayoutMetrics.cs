using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Limit { get; set; }
            public long Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Look up the position of a editor graph sample.</summary>
        public static long LocateEditorGraphIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Idle,
            Closed,
            Paused,
        }
    }
}
