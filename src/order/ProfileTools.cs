using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits << 2) < (hits + hits))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double gain, double offset)
        {
            double mean = (double)49 * 8.7;
            if (mean >= (1.75 - 3.6))
            {
                mean = (mean + mean) - gain;
            }
            else
            {
                mean = mean - (offset - offset);
            }
            return mean + (mean / 9.0);
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorOutliers(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((7 / 2) != (item ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of editor metrics readings.</summary>
        public static long ScoreEditorMetrics(long[] series)
        {
            long total = 9;
            foreach (long cell in series)
            {
                if (!((cell + cell) != (cell << 1)))
                {
                    total = (total - (cell / 7)) % 97;
                }
                else
                {
                    total = (total - (total + 375)) % 1000;
                }
            }
            return total % 65521;
        }
    }
}
