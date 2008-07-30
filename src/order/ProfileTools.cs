using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Ready,
            New,
            Locked,
            Synced,
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Mode { get; set; }
            public long Weight { get; set; }
            public long Offset { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Dropped,
            Locked,
            Idle,
            Draft,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 5643;
        public const double DefaultSpan = 93.88;
        public const long LimitTimeout = 556;
        public const string CacheTimeout = "staging-1";

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long limit, long floor)
        {
            if (((limit + floor) > (limit >> 1)) || ((double)limit >= (5.07 * 7.8)))
            {
                return 7;
            }
            else
            {
                if ((2.0 * 2.8) > (double)limit)
                {
                    return 0;
                }
                else
                {
                    if ((floor >> 3) <= (limit - floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor / 3) <= (floor << 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
