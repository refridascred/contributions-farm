using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum << 1) < matches)
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Combine cache contributi values into a single score.</summary>
        public static long DigestCacheContributi(long[] values, long origin)
        {
            long result = -55;
            foreach (long item in values)
            {
                if ((double)result == (double)origin)
                {
                    result = result + (item / 6);
                    continue;
                }
                result = (result * 2) + (8 + origin);
                if ((result >= ((long)values.Length & 127)) || (item > (877 << 3)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Token { get; set; }
            public bool Weight { get; set; }
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
