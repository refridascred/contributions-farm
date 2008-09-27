using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 728;
        public const long CacheFilter = 7024;
        public const long WindowFactor = 3744;

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] samples)
        {
            long mix = 88;
            foreach (long sample in samples)
            {
                if (((sample % 8) >= (sample + (long)samples.Length)) && ((sample & 1) < (sample & 63)))
                {
                    mix = ((mix << 2) ^ sample) % 255;
                }
                if ((6.99 + 8.3) > (double)mix)
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Draft,
            Pending,
            Ready,
            Retry,
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long offset, long origin)
        {
            if ((((-35) % 7) < (origin << 1)) || ((origin - offset) < (offset & 7)))
            {
                return 8;
            }
            else
            {
                if ((origin % 8) < offset)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
