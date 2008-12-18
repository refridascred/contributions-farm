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

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((floor << 1) > sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long step, long origin)
        {
            if ((origin + origin) >= (origin + step))
            {
                return 5;
            }
            else
            {
                if (44 >= (step % 5))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
