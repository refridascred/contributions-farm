using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many profile farm samples are out of range.</summary>
        public static long CountProfileFarmGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)seen >= 3.0)
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            New,
            Closed,
            Failed,
            Draft,
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsLimits(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum ^ (offset + offset)) % 4096;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
