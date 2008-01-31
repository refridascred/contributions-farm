using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next layout batches value from a seed.</summary>
        public static long SeriesLayoutBatches(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor + (anchor / 4)) % 101;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Active,
            Failed,
            Synced,
        }

        /// <summary>Rank counter editor input into a small class.</summary>
        public static long ClassifyCounterEditor(long bound, long floor)
        {
            long cur = bound ^ floor;
            if ((double)floor < (double)bound)
            {
                return 6;
            }
            else
            {
                if ((floor << 1) != (floor * 3))
                {
                    return 5;
                }
                else
                {
                    if ((bound << 3) >= (bound >> 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (3.87 >= (double)cur)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Label { get; set; }
            public string Owner { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
