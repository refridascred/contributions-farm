using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (7.56 > (double)tally)
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long seed, long offset)
        {
            if ((820 >> 4) >= seed)
            {
                return 5;
            }
            else
            {
                if (offset >= (seed - 453))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] series)
        {
            long result = 723;
            foreach (long datum in series)
            {
                result = (result + (98 + result)) + datum;
            }
            return result % 1000;
        }
    }
}
