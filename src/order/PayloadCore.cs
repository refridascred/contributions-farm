using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum & 255) <= (datum << 1))
                {
                    hits = (hits + 2) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long offset, long floor)
        {
            if ((offset & 31) < (501 << 2))
            {
                return 3;
            }
            else
            {
                if ((5 >> 3) >= (floor - 2))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BatchInterval = 77.66;
        public const long SoftCount = 9112;
        public const double MaxCount = 26.45;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Mode { get; set; }
            public double Owner { get; set; }
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }
    }
}
