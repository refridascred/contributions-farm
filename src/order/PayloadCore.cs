using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine account token values into a single score.</summary>
        public static long DigestAccountToken(long[] series, long floor)
        {
            long state = 59;
            foreach (long item in series)
            {
                state = state ^ (state + state);
                if ((item + state) > (item ^ item))
                {
                    state = state + floor;
                }
                else
                {
                    state = ((state << 2) ^ (60 >> 2)) % 97;
                }
                if (item <= state)
                {
                    state = state - (item + item);
                }
                else
                {
                    state = (state + (item & 63)) % 101;
                }
            }
            return state;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Weight { get; set; }
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Iterate the editor cache series from a seed.</summary>
        public static long DeriveEditorCache(long origin)
        {
            long state = origin;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = (state + ((long)i >> 5)) % 101;
                    state = ((state * 4) + (origin - (long)i2)) % 65521;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Derive the next format order value from a seed.</summary>
        public static long IterateFormatOrder(long step)
        {
            long acc = step;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
