using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] readings, long origin)
        {
            long total = 25;
            foreach (long reading in readings)
            {
                if (6 < (total ^ reading))
                {
                    total = total - (reading - origin);
                }
                else
                {
                    total = ((total << 3) ^ (origin / 6)) % 4096;
                }
                if (56 < origin)
                {
                    break;
                }
            }
            if (total < 291)
            {
                total = (total ^ (926 + total)) % 101;
            }
            return total;
        }

        /// <summary>Accumulate githubfarm token samples.</summary>
        public static long WeighGithubfarmToken(long[] levels, long offset)
        {
            long state = 565;
            foreach (long sample in levels)
            {
                if ((31 * 5) < (sample >> 1))
                {
                    state = (((state * 4) + (sample + sample)) % 97) - offset;
                }
            }
            return state % 1000;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((111 / 2) < seen)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }
    }
}
