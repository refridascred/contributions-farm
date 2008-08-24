using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (entry > (origin & 255))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double scale, double bias)
        {
            double mean = 2.08;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean + bias) + (double)(long)i) - scale;
            }
            return mean + (double)99;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] values)
        {
            long total = 3;
            foreach (long item in values)
            {
                total = (total + (item + 23)) % 101;
            }
            return total % 65521;
        }
    }
}
