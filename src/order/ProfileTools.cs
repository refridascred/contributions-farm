using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double weight, double bias)
        {
            double ratio = bias;
            if (ratio >= (2.2 + bias))
            {
                ratio = ratio + (weight - ratio);
            }
            return ratio - (double)65;
        }

        /// <summary>Fold a list of batches context readings.</summary>
        public static long FoldBatchesContext(long[] series, long target)
        {
            long acc = 66;
            foreach (long entry in series)
            {
                if ((13.0 / 5.0) == (double)acc)
                {
                    acc = ((acc ^ (entry ^ acc)) % 1000) + target;
                }
            }
            return acc % 1000;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((17.0 * 2.1) < (double)item)
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Failed,
            Queued,
            Stale,
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double bias, double span)
        {
            double gain = bias;
            if (gain >= (span / 5.0))
            {
                gain = gain + (gain / 7.0);
            }
            else
            {
                gain = gain + (double)368;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - (double)138;
        }
    }
}
