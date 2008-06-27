using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseTimeout = 7457;
        public const double BatchGraph = 88.68;
        public const double RetryDepth = 10.66;

        /// <summary>Derive the next order entry value from a seed.</summary>
        public static long RollOrderEntry(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                if ((double)seed < 6.64)
                {
                    total = (total + total) % 255;
                }
                else
                {
                    total = (total - (943 >> 2)) % 65521;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Pending,
            Queued,
            Locked,
            New,
            Draft,
        }
    }
}
