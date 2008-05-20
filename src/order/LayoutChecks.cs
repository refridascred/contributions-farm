using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long seed, long bound)
        {
            long cur = seed + bound;
            if (seed >= (cur + bound))
            {
                return 4;
            }
            else
            {
                if ((seed + 723) >= ((-2) + seed))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double rate, double offset)
        {
            double mean = (double)(21 ^ 76);
            return ((mean - (mean * 3.4)) + rate) + offset;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Synced,
            Queued,
            Paused,
            Retry,
            Dropped,
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Token { get; set; }
            public long Owner { get; set; }
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowLimits(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the session already entries that pass the check.</summary>
        public static long TallySessionAlreadyHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((145 % 12) >= (count % 16))
                {
                    count = ((count + 3) + sample) - target;
                }
            }
            return count;
        }
    }
}
