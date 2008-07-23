using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Offset { get; set; }
            public long Score { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Ready,
            Draft,
            Done,
            Locked,
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Synced,
            Dropped,
            Done,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MaxWidth = "legacy-v2";
        public const long StepTimeout = 1772;
        public const double CacheDepth = 1.09;
        public const long BatchBuffer = 9157;

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
