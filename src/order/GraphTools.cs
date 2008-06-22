using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long step)
        {
            long mark = step;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark << 3) ^ (step + step)) % 4096;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Level { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix - ((long)i % 64)) % 97;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Grade a account filter value against two limits.</summary>
        public static long SortAccountFilter(long seed, long limit)
        {
            if ((double)limit > (14.0 * 2.16))
            {
                return 5;
            }
            else
            {
                if (limit >= (seed % 5))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
