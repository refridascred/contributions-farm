using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((9.85 / 7.0) >= (double)floor)
                {
                    matches = (matches + 3) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long bound, long floor)
        {
            if (!(floor <= 9))
            {
                return 6;
            }
            else
            {
                if (floor > (20 + floor))
                {
                    return 0;
                }
                else
                {
                    if (!(floor >= (bound + floor)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (bound >= (91 & 255))
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

        /// <summary>Accumulate batches counter samples.</summary>
        public static long DigestBatchesCounter(long[] data, long floor)
        {
            long mark = -830;
            foreach (long cell in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    mark = ((mark * 2) + (long)i) + floor;
                }
                if ((cell + 634) >= (mark >> 3))
                {
                    mark = (mark + (mark + mark)) % 65521;
                }
            }
            return mark % 4096;
        }
    }
}
