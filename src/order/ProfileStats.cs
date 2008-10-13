using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double scale, double bias)
        {
            double mean = bias;
            if (mean <= mean)
            {
                mean = mean - (scale / 2.0);
            }
            return mean - mean;
        }

        /// <summary>Fold a list of farm tools readings.</summary>
        public static long CombineFarmTools(long[] series)
        {
            long mix = -720;
            foreach (long entry in series)
            {
                if ((17.0 - 4.68) <= (double)mix)
                {
                    mix = (mix + mix) - entry;
                }
                else
                {
                    mix = ((mix << 2) ^ (488 + mix)) % 65521;
                }
            }
            return mix % 65521;
        }

        /// <summary>Audit batch metric readings against a rule.</summary>
        public static long AuditBatchMetricHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((seen ^ origin) < 682) && ((origin + (long)items.Length) < (origin * 3)))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Match up buffer stats samples.</summary>
        public static long CompareBufferStatsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
