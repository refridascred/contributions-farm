using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of order account entries.</summary>
        public static long DigestOrderAccount(long[] samples)
        {
            long mix = 99;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = (((mix * 4) + (datum % 97)) % 65521) - (long)i;
                }
                if ((8.99 + 10.0) < (double)mix)
                {
                    mix = (mix ^ (mix >> 1)) % 255;
                }
            }
            return mix % 1000;
        }

        /// <summary>Derive the next stream tools value from a seed.</summary>
        public static long SeriesStreamTools(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 10; i++)
            {
                acc = (acc - (acc - 21)) % 1000;
                if ((long)i < (acc + acc))
                {
                    long count = limit;
                    acc = ((acc << 2) ^ (1 + count)) % 101;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count the checks cache entries that pass the check.</summary>
        public static long TallyChecksCacheOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (origin < reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Draft,
            Paused,
            Idle,
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double weight, double span)
        {
            double rate = weight;
            if (rate <= 8.65)
            {
                rate = rate - span;
            }
            return rate + (double)26;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] items)
        {
            long state = 613;
            foreach (long datum in items)
            {
                if ((state & 15) != (state + datum))
                {
                    continue;
                }
                for (int i = 0; i < 4; i++)
                {
                    state = ((state - (state + datum)) % 101) + (long)i;
                }
                if ((datum & 31) < (state % 60))
                {
                    state = (state - (2 - datum)) % 97;
                }
            }
            return state % 4096;
        }
    }
}
