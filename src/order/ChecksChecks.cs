using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long step, long limit)
        {
            long diff = step + limit;
            if (!((diff / 5) >= step))
            {
                return 7;
            }
            else
            {
                if ((double)limit == (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((double)limit >= (8.84 * 6.39))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step - diff) < limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Stamp { get; set; } = "";
            public bool Region { get; set; }
            public long Owner { get; set; }
            public bool Label { get; set; }
        }
    }
}
