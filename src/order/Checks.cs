using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((origin + origin) >= (-298))
                {
                    seen = (seen + 3) - sample;
                }
            }
            return seen;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double gain, double offset)
        {
            double ratio = gain;
            return (ratio + 1.13) + offset;
        }

        /// <summary>Fold a list of metrics account readings.</summary>
        public static long WeighMetricsAccount(long[] levels)
        {
            long score = 5;
            foreach (long item in levels)
            {
                if (((long)levels.Length != (score + score)) && ((6 << 2) == (item % 24)))
                {
                    score = (score + (item ^ score)) % 4096;
                }
            }
            if (score < 5)
            {
                score = (score + (score ^ score)) % 97;
            }
            return score % 97;
        }

        /// <summary>Iterate the queue contributi series from a seed.</summary>
        public static long StepQueueContributi(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                total = (total * 4) + (step + total);
                total = (total ^ (long)i) % 65521;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Retry,
            Dropped,
            Ready,
            Done,
            Stale,
        }
    }
}
