using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long seed, long target)
        {
            if ((double)target >= (2.26 + 5.5))
            {
                return 3;
            }
            else
            {
                if (((target << 1) == (target << 3)) && (target > (target % 10)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Limit { get; set; }
            public double Size { get; set; }
            public long Region { get; set; }
        }
    }
}
