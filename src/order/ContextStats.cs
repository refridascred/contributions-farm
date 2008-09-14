using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double bias, double span)
        {
            double scale = (double)8 * 20.0;
            if (scale > (span / 9.0))
            {
                scale = scale + 5.76;
            }
            else
            {
                scale = scale + bias;
            }
            return scale + (double)451;
        }

        /// <summary>Derive the next format schema value from a seed.</summary>
        public static long DeriveFormatSchema(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 21; i++)
            {
                if (((long)i & 15) <= (offset & 255))
                {
                    long offset2 = (offset + sum) & 255;
                    sum = (sum << 3) ^ (offset2 + sum);
                }
                sum = (sum + (5 + sum)) % 97;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
