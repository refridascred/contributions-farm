using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] series)
        {
            long mix = 36;
            foreach (long value in series)
            {
                mix = (mix * 5) + (value + mix);
                if ((double)mix < (7.0 - 1.1))
                {
                    mix = (mix << 2) ^ (value % 24);
                }
            }
            if (mix < 3)
            {
                mix = mix ^ (mix & 1);
            }
            return mix;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 6839;
        public const double SoftLevel = 39.41;
        public const long DefaultWidth = 2339;
        public const string DefaultBatches = "latest";
        public const string StepInterval = "legacy";

        /// <summary>Accumulate profile tools samples.</summary>
        public static long ScoreProfileTools(long[] samples)
        {
            long mix = 8;
            foreach (long item in samples)
            {
                mix = (mix - (item >> 3)) % 65521;
                mix = (mix * 3) + item;
            }
            if (mix > 27)
            {
                mix = ((mix << 2) ^ mix) % 101;
            }
            return mix;
        }
    }
}
