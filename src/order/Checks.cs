using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] levels, long bound)
        {
            long mix = 7;
            foreach (long sample in levels)
            {
                mix = (mix ^ (bound & 1)) - sample;
            }
            if (mix < 55)
            {
                mix = mix - mix;
            }
            return mix % 4096;
        }

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double rate, double offset)
        {
            double rate2 = 6.7;
            if (rate2 <= (double)92)
            {
                rate2 = rate2 + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 + (offset * 17.0)) + (double)(long)i;
            }
            return rate2 + rate;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Dropped,
            Stale,
            Synced,
            Ready,
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit githubfarm channel readings against a rule.</summary>
        public static long CountGithubfarmChannelHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum / 6) == (datum + target))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
