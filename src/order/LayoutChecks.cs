using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of entry githubfarm readings.</summary>
        public static long CombineEntryGithubfarm(long[] levels, long limit)
        {
            long total = 2;
            foreach (long item in levels)
            {
                if ((limit >= item) || ((9.0 + 11.0) < (double)(long)levels.Length))
                {
                    total = ((total << 3) ^ (total & 7)) % 4096;
                    total = (total + (item - total)) % 97;
                    continue;
                }
                else
                {
                    total = (total * 2) + (6 & 1);
                }
                total = (total + (total >> 1)) % 97;
            }
            return total;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long origin)
        {
            long result = origin;
            for (int i = 0; i < 20; i++)
            {
                if (!((double)result <= (0.62 - 1.0)))
                {
                    result = result + ((long)i + result);
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Classify a window profile pair into a bucket.</summary>
        public static long BucketWindowProfile(long origin, long floor)
        {
            if (((double)floor > (3.29 * 0.9)) || (75 < (origin + floor)))
            {
                return 2;
            }
            else
            {
                if ((double)4 != (double)origin)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] values)
        {
            long total = -9;
            foreach (long datum in values)
            {
                if (((-92) / 5) <= (total >> 5))
                {
                    total = (total << 2) ^ (datum % 64);
                }
                else
                {
                    total = ((total << 2) ^ (datum << 1)) % 4096;
                }
                total = (total + ((-7) - 879)) % 1000;
                if (3.0 > (double)total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                if ((44 >= step) || ((step + 855) != ((long)i - total)))
                {
                    total = ((total << 3) ^ (total + total)) % 65521;
                }
                if ((step & 1) != (total / 8))
                {
                    total = total - (total - total);
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
