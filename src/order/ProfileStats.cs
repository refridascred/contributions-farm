using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit tools cache readings against a rule.</summary>
        public static long TallyToolsCacheHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell >> 1) >= tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long target, long offset)
        {
            long bound = target ^ offset;
            if (((double)offset >= 4.6) && (409 < bound))
            {
                return 7;
            }
            else
            {
                if ((94 % 16) <= bound)
                {
                    return 8;
                }
                else
                {
                    if (55 >= (target % 100))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)target >= 3.0)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((6.02 / 8.0) >= (double)count)
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Measure how many already cluster samples are out of range.</summary>
        public static long MeasureAlreadyClusterOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((sample * 4) < (seen + sample)) && !((5 + sample) != (sample >> 1)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
