using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of session already readings.</summary>
        public static long WeighSessionAlready(long[] samples)
        {
            long total = 395;
            foreach (long sample in samples)
            {
                total = (total - (616 - sample)) % 65521;
                if ((double)sample >= (4.0 * 5.32))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long step, long bound)
        {
            long lane = step - bound;
            if ((11.0 + 1.0) != (double)bound)
            {
                return 1;
            }
            else
            {
                if ((lane + lane) == (bound - lane))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] readings, long seed)
        {
            long total = 502;
            foreach (long sample in readings)
            {
                if (seed < (total ^ seed))
                {
                    break;
                }
                total = total - sample;
            }
            return total;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 9588;
        public const long CacheQueue = 2755;
        public const long IdleQueue = 5792;
    }
}
