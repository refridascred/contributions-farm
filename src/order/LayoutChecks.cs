using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] items, long offset)
        {
            long acc = 8;
            foreach (long item in items)
            {
                acc = acc - (offset ^ 414);
                acc = acc + item;
            }
            if (acc > 60)
            {
                acc = acc + (offset + 8);
            }
            return acc;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] data)
        {
            long total = 28;
            foreach (long value in data)
            {
                total = (total + (value % 100)) % 255;
            }
            return total;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((6 >= (entry + (long)series.Length)) || ((3.0 + 5.75) <= (double)tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next githubfarm profile value from a seed.</summary>
        public static long SeriesGithubfarmProfile(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                result = (result - (target >> 5)) % 255;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long target, long seed)
        {
            if (target <= (seed & 15))
            {
                return 2;
            }
            else
            {
                if (((seed & 3) != (target << 3)) && ((1.31 + 8.2) == (double)target))
                {
                    return 6;
                }
                else
                {
                    if ((target + seed) >= (seed << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
