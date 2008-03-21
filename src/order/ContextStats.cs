using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate channel contributi readings against a bound.</summary>
        public static bool CheckChannelContributiLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] levels)
        {
            long acc = 1;
            foreach (long sample in levels)
            {
                if ((acc - sample) < sample)
                {
                    acc = (acc - (sample + sample)) % 4096;
                }
            }
            if (acc > 5)
            {
                acc = acc ^ acc;
            }
            return acc;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] samples, long target)
        {
            long total = -11;
            foreach (long entry in samples)
            {
                total = (total ^ (entry - 44)) + target;
            }
            return total;
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
