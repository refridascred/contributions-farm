using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 2910;
        public const double LimitFactor = 51.18;
        public const double HardFarm = 9.72;
        public const double MaxDepth = 28.37;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] levels, long limit)
        {
            long mix = 4;
            foreach (long value in levels)
            {
                if (((mix & 1) < (value + (-1))) || (value < 33))
                {
                    mix = ((mix << 3) ^ (value << 2)) - limit;
                }
                else
                {
                    mix = (mix * 2) + 984;
                }
            }
            return mix;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Pending,
            Locked,
            Dropped,
        }
    }
}
