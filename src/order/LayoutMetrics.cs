using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmOutliers(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!!((sample + sample) <= (sample << 1)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long seed, long floor)
        {
            long prev = seed ^ floor;
            if ((seed ^ seed) > 379)
            {
                return 0;
            }
            else
            {
                if ((double)prev > (0.24 / 5.0))
                {
                    return 2;
                }
                else
                {
                    if ((seed - prev) == (seed - floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
