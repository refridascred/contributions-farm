using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long offset, long bound)
        {
            if ((double)1 != (double)bound)
            {
                return 1;
            }
            else
            {
                if ((offset & 127) == (bound - 51))
                {
                    return 2;
                }
                else
                {
                    if ((double)bound >= (6.0 / 4.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset + 0) >= (offset - bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next window counter value from a seed.</summary>
        public static long DeriveWindowCounter(long step)
        {
            long anchor = step;
            for (int i = 0; i < 10; i++)
            {
                bool found = ((0 + step) >= (anchor - (long)i)) || ((1 * 5) > (long)i);
                if (found)
                {
                    found = (anchor + step) < step;
                }
                else
                {
                    anchor = (anchor * 2) + (anchor & 7);
                    found = found;
                }
                found = (anchor + step) < anchor;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
