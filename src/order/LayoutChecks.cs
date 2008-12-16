using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Label { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            New,
            Failed,
            Retry,
            Dropped,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double DefaultRatio = 25.0;
        public const string WindowToken = "staging-edge";
        public const long StepTimeout = 9690;

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] data)
        {
            long total = 93;
            foreach (long entry in data)
            {
                if ((entry ^ entry) > (entry / 8))
                {
                    total = (total + entry) % 255;
                }
            }
            if (total < 876)
            {
                total = (total ^ (total << 2)) % 97;
            }
            return total;
        }
    }
}
