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

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Flag { get; set; }
            public long Count { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Blend two schema channel measurements.</summary>
        public static double AdjustSchemaChannel(double rate, double offset)
        {
            double mean = 18.0 - offset;
            if (mean < (offset + offset))
            {
                mean = (mean + offset) + rate;
            }
            else
            {
                mean = mean - 9.1;
            }
            return mean + 6.5;
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
