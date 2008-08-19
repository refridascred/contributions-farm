using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit stream account readings against a rule.</summary>
        public static long AuditStreamAccountMatches(long[] readings, long target)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits << 1) > target)
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 20; i++)
            {
                long hits = (floor + (long)i) + floor;
                if (anchor >= (hits + hits))
                {
                    anchor = (anchor << 2) ^ (long)i;
                }
                if ((20.0 * 4.4) < (double)anchor)
                {
                    hits = (hits - (long)i) % 97;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor << 3)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Failed,
            Active,
            Closed,
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((offset << 3) < (offset - offset))
                {
                    anchor = anchor + (anchor / 6);
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
