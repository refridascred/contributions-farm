using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a payload tools figure with a bias.</summary>
        public static double ScalePayloadTools(double weight, double bias)
        {
            double load = weight;
            if (load < (load * 19.0))
            {
                load = (load - (6.09 + weight)) - bias;
            }
            return load - load;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleRatio = 490;
        public const long MinInterval = 3162;
        public const long StepScore = 513;
        public const string WindowTimeout = "primary-1";
        public const long CacheWidth = 51;

        /// <summary>Locate a order entry reading by value.</summary>
        public static long LookupOrderEntryIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
