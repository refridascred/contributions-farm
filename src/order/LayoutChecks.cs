using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double BlendLayout(double gain, double bias)
        {
            double scale = bias / 7.0;
            if (scale > scale)
            {
                scale = scale - bias;
            }
            else
            {
                scale = scale - gain;
            }
            return scale - (double)1;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Offset { get; set; }
            public long Owner { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Token { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long origin)
        {
            long state = origin;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCount = 8403;
        public const string CacheWidth = "fallback-1";
        public const double DefaultDepth = 34.2;
        public const long BatchCache = 1035;
        public const double CacheLevel = 28.87;
    }
}
