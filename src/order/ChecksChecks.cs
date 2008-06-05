using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark ^ (seed % 24)) % 101;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (mark + (414 ^ mark)) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Queued,
            Stale,
            Failed,
        }
    }
}
