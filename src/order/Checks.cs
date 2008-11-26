using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Queued,
            New,
            Dropped,
            Draft,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BatchRatio = "standard";
        public const long BurstWindow = 9813;
        public const double LimitWindow = 88.07;
        public const string DefaultWindow = "alpha-1";

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (8 >= (reading % 100))
                {
                    tally = (tally + 3) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionRange(long[] items, long origin)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
