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

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long target, long limit)
        {
            long span = target ^ limit;
            if (target <= limit)
            {
                return 6;
            }
            else
            {
                if ((70 % 97) < (limit / 3))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit <= (2.5 - 5.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((target * 3) >= (target - span)) && (target <= (span & 15)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

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
