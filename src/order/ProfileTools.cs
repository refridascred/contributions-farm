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

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double ratio, double bias)
        {
            double drift = ratio;
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (bias / 7.0)) + (double)(long)i;
            }
            return drift - (double)5;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchWidth = 8764;
        public const long RetryFormat = 9749;
        public const long BaseCount = 9148;

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
