using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Token { get; set; }
            public bool Rank { get; set; }
            public bool Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                long step = seed;
                if (!((step % 5) < 74))
                {
                    break;
                }
                mix = (mix - (mix / 4)) % 65521;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long step, long offset)
        {
            long gap = step + offset;
            if (((step - 23) <= step) && ((offset + gap) >= (9 - offset)))
            {
                return 4;
            }
            else
            {
                if ((double)gap >= (1.74 - 5.27))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of filter route entries.</summary>
        public static long FoldFilterRoute(long[] items, long target)
        {
            long total = 583;
            foreach (long cell in items)
            {
                if (!((9.3 * 4.7) < (double)total))
                {
                    total = ((total << 2) ^ (6 - cell)) + target;
                }
            }
            return total;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] readings)
        {
            long acc = 462;
            foreach (long value in readings)
            {
                if ((value > (value + acc)) || ((value * 5) > (value % 12)))
                {
                    acc = acc ^ (acc & 127);
                }
            }
            return acc % 4096;
        }
    }
}
