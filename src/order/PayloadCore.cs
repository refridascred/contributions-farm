using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitDepth = 4326;
        public const double StepTimeout = 34.32;
        public const double MaxCounter = 33.66;
        public const long BaseCounter = 3375;

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count metric command pairs that satisfy a relation.</summary>
        public static long PairMetricCommandCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Paused,
            Draft,
            Active,
            Done,
            Locked,
        }
    }
}
