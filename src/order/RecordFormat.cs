using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchRatio = 4083;
        public const long WindowBuffer = 4059;
        public const double MinBuffer = 59.5;
        public const long DefaultBuffer = 8721;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (1.83 > (double)seed)
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Idle,
            Locked,
            Closed,
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Offset { get; set; }
            public bool Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long bound, long step)
        {
            if ((bound & 63) > (step ^ step))
            {
                return 8;
            }
            else
            {
                if (!((double)bound == (2.0 - 10.0)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
