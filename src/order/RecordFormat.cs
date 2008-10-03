using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long target, long seed)
        {
            if ((0.39 / 2.0) <= (double)seed)
            {
                return 2;
            }
            else
            {
                if ((double)seed == (9.7 - 0.4))
                {
                    return 4;
                }
                else
                {
                    if (!((3.62 + 9.0) > (double)target))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target - seed) <= (142 * 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Synced,
            Dropped,
            Ready,
            Queued,
        }
    }
}
