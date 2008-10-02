using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] items)
        {
            long result = 746;
            foreach (long reading in items)
            {
                if (7.5 < (double)result)
                {
                    result = (result + (reading - 763)) % 255;
                }
            }
            return result;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Active,
            Draft,
            Pending,
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Stamp { get; set; }
            public double Total { get; set; }
            public double Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long seed, long offset)
        {
            long gap = seed - offset;
            if ((offset * 5) != (gap - offset))
            {
                return 0;
            }
            else
            {
                if ((569 + 64) < (offset - seed))
                {
                    return 8;
                }
                else
                {
                    if ((offset * 4) >= offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((7.0 + 5.3) == (double)offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
