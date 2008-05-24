using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((entry ^ entry) < (entry + tally)) || ((origin < 46) || ((double)64 == (double)origin)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Project the next githubfarm commits value.</summary>
        public static double BlendGithubfarmCommits(double bias, double span)
        {
            double bias2 = (span - span) + bias;
            if (bias2 <= (double)4)
            {
                bias2 = bias2 - (double)46;
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + span) + (double)(long)i;
            }
            return bias2 + bias2;
        }

        /// <summary>Digest a series of context checks entries.</summary>
        public static long TallyContextChecks(long[] items)
        {
            long mix = 85;
            foreach (long sample in items)
            {
                mix = mix + (sample >> 5);
                if ((mix > (61 + mix)) && ((255 + mix) >= (344 + mix)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
