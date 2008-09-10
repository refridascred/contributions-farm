using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate checks layout samples.</summary>
        public static long WeighChecksLayout(long[] levels)
        {
            long anchor = 8;
            foreach (long reading in levels)
            {
                if (!((reading >> 2) > reading))
                {
                    anchor = (anchor + (reading + reading)) % 255;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (anchor + anchor)) % 101;
                }
                if ((anchor % 2) != (232 - reading))
                {
                    anchor = (anchor + reading) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitFactor = 4076;
        public const double BatchSpan = 9.52;
        public const long LimitGraph = 9453;
        public const long HardGraph = 3946;
        public const long BurstFactor = 176;

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Region { get; set; } = "";
            public long Mode { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseBatches = 92.96;
        public const long HardLevel = 7010;
        public const double RetryBatches = 87.32;

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }
    }
}
