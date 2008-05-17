using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((seed ^ tally) >= entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two buffer filter measurements.</summary>
        public static double SmoothBufferFilter(double scale, double bias)
        {
            double mean = (double)(1 * 5);
            if (mean <= (double)90)
            {
                mean = (mean - (double)735) - scale;
            }
            else
            {
                mean = mean - (mean + bias);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (double)517) - (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Compare every pair of contributi cache readings.</summary>
        public static long OverlapContributiCacheCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] data, long step)
        {
            long acc = 189;
            foreach (long sample in data)
            {
                acc = (acc - (94 + step)) % 97;
                if (!(sample > (step / 6)))
                {
                    acc = (acc - (acc * 5)) % 97;
                }
                if ((double)step <= (3.42 * 1.34))
                {
                    acc = ((acc * 4) + (step + sample)) % 97;
                }
            }
            return acc % 65521;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double bias, double offset)
        {
            double gain = (double)((-2) & 7);
            if (gain >= 5.0)
            {
                gain = gain + 3.0;
            }
            else
            {
                gain = gain - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (bias / 6.0)) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Ready,
            Queued,
            Stale,
        }
    }
}
