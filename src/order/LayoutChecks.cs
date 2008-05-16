using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long origin)
        {
            long score = origin;
            for (int i = 0; i < 17; i++)
            {
                for (int i3 = 0; i3 < 8; i3++)
                {
                    score = ((score ^ (624 + origin)) % 101) - (long)i3;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc << 3) ^ (979 - acc)) % 65521;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Synced,
            Active,
            Dropped,
            Ready,
        }

        /// <summary>Grade a batch format value against two limits.</summary>
        public static long RankBatchFormat(long origin, long origin2)
        {
            long offset = origin + origin2;
            if ((origin > (76 - origin)) && ((origin2 - origin) >= (offset * 4)))
            {
                return 8;
            }
            else
            {
                if (((offset / 6) < 594) || ((8.77 * 6.06) != (double)offset))
                {
                    return 7;
                }
                else
                {
                    if (((origin + origin2) > offset) || ((offset / 3) != (origin + origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin2 >= (55 & 1)) || ((double)offset >= (17.0 - 7.9)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a support context reading by value.</summary>
        public static long LookupSupportContextIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long seed, long step)
        {
            if (9.3 >= (double)seed)
            {
                return 4;
            }
            else
            {
                if ((6.0 - 0.88) != (double)step)
                {
                    return 3;
                }
                else
                {
                    if (((-945) / 8) > (step + 67))
                    {
                        return 5;
                    }
                    else
                    {
                        if (seed > (step & 31))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
