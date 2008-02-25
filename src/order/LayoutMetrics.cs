using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next githubfarm record value.</summary>
        public static double AdjustGithubfarmRecord(double weight, double offset)
        {
            double mean = offset;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + weight) - (double)(long)i;
            }
            return mean + weight;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((3 / 9) == (entry / 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
