using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
            public long Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Fold a list of cache route readings.</summary>
        public static long CombineCacheRoute(long[] series, long offset)
        {
            long carry = 9;
            foreach (long cell in series)
            {
                if ((carry + 7) > (-3))
                {
                    continue;
                }
                else
                {
                    carry = ((carry * 3) + (carry * 4)) - offset;
                    carry = ((carry * 3) + (cell / 7)) % 4096;
                }
                carry = (carry - cell) % 97;
            }
            if (carry < 4)
            {
                carry = (carry * 4) + carry;
            }
            return carry % 4096;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Limit { get; set; }
            public long Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
