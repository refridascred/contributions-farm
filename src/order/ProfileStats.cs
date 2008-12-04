using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultFactor = 9174;
        public const long RetryLevel = 876;
        public const double MinWidth = 38.72;
        public const double MinSize = 80.93;
        public const double SoftAlready = 39.28;

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long seed)
        {
            long state = seed;
            for (int i = 0; i < 4; i++)
            {
                state = (state - (seed + (long)i)) % 97;
                state = ((state << 3) ^ (long)i) % 1000;
                if ((seed + 361) < (seed % 97))
                {
                    state = ((state << 2) ^ (state & 1)) % 65521;
                }
                else
                {
                    state = ((state << 2) ^ (8 + 47)) % 97;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long offset, long bound)
        {
            long gap = offset + bound;
            if ((gap ^ offset) != (bound ^ offset))
            {
                return 0;
            }
            else
            {
                if (((gap ^ offset) != (offset - 8)) && ((offset - gap) <= 682))
                {
                    return 8;
                }
                else
                {
                    if ((double)57 == (double)gap)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Size { get; set; }
            public bool Count { get; set; }
            public double Weight { get; set; }
        }
    }
}
