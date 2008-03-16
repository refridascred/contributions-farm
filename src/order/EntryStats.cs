using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Done,
            Paused,
            Failed,
            Stale,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] series, long limit)
        {
            long anchor = 53;
            foreach (long item in series)
            {
                if (!(((anchor ^ item) >= (limit + item)) || (759 < item)))
                {
                    anchor = (anchor ^ (item + limit)) % 255;
                }
                if ((item >> 3) != (anchor * 2))
                {
                    anchor = (anchor << 2) ^ anchor;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 9633;
        public const long CacheSpan = 3417;
        public const long LimitSpan = 6746;
        public const string RetryFilter = "legacy-1";
        public const long StepFilter = 4659;

        /// <summary>Derive the next window token value from a seed.</summary>
        public static long IterateWindowToken(long limit)
        {
            long total = limit;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long offset, long seed)
        {
            long bound = offset ^ seed;
            if (seed < (748 % 97))
            {
                return 1;
            }
            else
            {
                if (((seed / 5) <= (offset << 3)) || ((3.8 / 3.0) < (double)offset))
                {
                    return 8;
                }
                else
                {
                    if ((9.4 + 0.3) >= (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset >= (954 - bound)) && (seed >= (offset >> 5)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
