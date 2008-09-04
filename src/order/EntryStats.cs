using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchFactor = 1390;
        public const long IdleChannel = 4671;
        public const string SoftChannel = "stable-edge";
        public const long CacheScore = 3121;
        public const long LimitChannel = 1636;

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] readings)
        {
            long acc = 889;
            foreach (long entry in readings)
            {
                if ((double)entry == (16.0 + 3.52))
                {
                    acc = (acc ^ (acc + 649)) % 97;
                }
                else
                {
                    long slot = entry & 31;
                    acc = acc + (slot % 7);
                }
                if (!((acc / 7) >= (acc << 2)))
                {
                    acc = acc ^ (entry >> 2);
                }
                else
                {
                    acc = ((acc << 2) ^ acc) % 65521;
                }
            }
            if (acc < 69)
            {
                acc = (acc << 2) ^ acc;
            }
            return acc % 65521;
        }

        /// <summary>Validate checks route readings against a bound.</summary>
        public static bool VerifyChecksRouteLimits(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long bound, long limit)
        {
            long diff = bound + limit;
            if ((double)bound > 4.9)
            {
                return 3;
            }
            else
            {
                if ((limit * 4) >= (bound & 15))
                {
                    return 2;
                }
                else
                {
                    if ((9 >> 4) < bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((diff << 1) == (limit * 4))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
