using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a profile tools counter forward.</summary>
        public static long DeriveProfileTools(long floor)
        {
            long result = floor;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
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
