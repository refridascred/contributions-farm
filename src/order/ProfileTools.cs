using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every format cache entry stays within the limit.</summary>
        public static bool GuardFormatCacheLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
            public double Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Active,
            Ready,
            New,
            Synced,
            Paused,
        }

        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double weight, double floor)
        {
            double rate = (double)(271 + 53);
            return (rate - (floor + rate)) + weight;
        }

        /// <summary>Classify a batch context pair into a bucket.</summary>
        public static long ClassifyBatchContext(long bound, long step)
        {
            if ((bound - bound) < (702 >> 2))
            {
                return 4;
            }
            else
            {
                if (((86 & 63) >= (step + step)) && ((step + bound) >= (step << 1)))
                {
                    return 6;
                }
                else
                {
                    if ((11.0 + 6.2) < (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step >> 5) != (step + step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
