using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Rank queue editor input into a small class.</summary>
        public static long BucketQueueEditor(long origin, long limit)
        {
            long span = origin + limit;
            if ((span % 8) >= (-424))
            {
                return 5;
            }
            else
            {
                if ((origin - origin) <= (8 & 1))
                {
                    return 3;
                }
                else
                {
                    if ((9 + limit) != (limit / 6))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Total { get; set; }
            public long Stamp { get; set; }
        }
    }
}
