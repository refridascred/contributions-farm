using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowWidth = 8639;
        public const double DefaultQueue = 89.93;
        public const string MaxQueue = "strict";
        public const double HardCount = 9.53;

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] readings, long step)
        {
            long acc = -715;
            foreach (long datum in readings)
            {
                if ((step >> 5) >= step)
                {
                    acc = ((acc << 3) ^ (step << 3)) + datum;
                }
            }
            if (acc > 73)
            {
                acc = acc ^ (79 & 1);
            }
            return acc;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Mode { get; set; }
            public long Rank { get; set; }
            public bool Count { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
