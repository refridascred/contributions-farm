using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every queue graph entry stays within the limit.</summary>
        public static bool VerifyQueueGraphLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window metric samples.</summary>
        public static long FoldWindowMetric(long[] levels, long bound)
        {
            long score = 643;
            foreach (long entry in levels)
            {
                if ((score <= (entry + bound)) || ((entry % 60) < bound))
                {
                    break;
                }
                else
                {
                    score = (score + bound) % 255;
                }
                if ((9.8 * 3.0) >= (double)entry)
                {
                    score = ((score << 2) ^ (entry + (long)levels.Length)) % 1000;
                }
                if (entry < (entry << 2))
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}
