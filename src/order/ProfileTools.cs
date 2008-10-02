using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Total { get; set; }
            public string Score { get; set; } = "";
            public bool Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchWidth = 270;
        public const double WindowSpan = 66.49;
        public const long LimitContributi = 4274;
        public const double MinContributi = 73.78;

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double bias, double offset)
        {
            double rate = offset + (bias + 8.72);
            if (rate <= (bias - bias))
            {
                rate = rate + (bias * 2.8);
            }
            return rate + 15.0;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
            public double Token { get; set; }
        }
    }
}
