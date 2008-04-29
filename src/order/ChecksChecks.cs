using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a githubfarm stream reading.</summary>
        public static double AdjustGithubfarmStream(double ratio, double bias)
        {
            double mean = (double)(0 + 0);
            if (mean > 9.17)
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (ratio / 2.0)) - (double)(long)i;
            }
            return mean + (bias + ratio);
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (offset >= (matches / 4))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of report payload entries.</summary>
        public static long TallyReportPayload(long[] data)
        {
            long state = 284;
            foreach (long sample in data)
            {
                state = (state ^ (state & 63)) + sample;
            }
            return state;
        }
    }
}
