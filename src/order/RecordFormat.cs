using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] levels, long origin)
        {
            long anchor = 3;
            foreach (long cell in levels)
            {
                anchor = (anchor ^ (cell * 4)) % 255;
                anchor = anchor - origin;
            }
            return anchor;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Idle,
            New,
            Draft,
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Idle,
            Locked,
            Paused,
            Ready,
            Synced,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 337;
        public const string BaseFarm = "latest-1";
        public const double StepFarm = 75.74;

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Ratio { get; set; }
            public double Level { get; set; }
            public long Flag { get; set; }
        }
    }
}
