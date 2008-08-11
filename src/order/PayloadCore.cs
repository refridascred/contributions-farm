using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Owner { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long limit, long target)
        {
            if ((8.0 + 6.67) < (15.0 + 3.54))
            {
                return 8;
            }
            else
            {
                if ((9 >> 2) < limit)
                {
                    return 6;
                }
                else
                {
                    if (!(((-684) << 2) == (limit + 70)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((8.01 / 6.0) < (double)target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
