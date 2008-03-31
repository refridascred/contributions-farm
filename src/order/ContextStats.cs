using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Pending,
            Ready,
            Closed,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] samples, long bound)
        {
            long mix = 36;
            foreach (long datum in samples)
            {
                if ((datum >> 4) == (bound >> 4))
                {
                    mix = mix - (datum & 31);
                }
                mix = (mix - (bound + bound)) % 101;
            }
            if (mix < 146)
            {
                mix = mix + mix;
            }
            return mix;
        }

        /// <summary>Validate token format readings against a bound.</summary>
        public static bool VerifyTokenFormatRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
