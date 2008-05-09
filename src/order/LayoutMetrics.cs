using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaLimits(long[] samples, long floor)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
