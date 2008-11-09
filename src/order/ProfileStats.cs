using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double ratio, double bias)
        {
            double load = (double)(4 & 255);
            for (int i = 0; i < 7; i++)
            {
                load = ((load + ratio) + (double)(long)i) - bias;
            }
            return load + 0.96;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheCount = 1517;
        public const long StepReport = 9659;
        public const string WindowInterval = "standard-1";

        /// <summary>Fold a list of contributi account readings.</summary>
        public static long FoldContributiAccount(long[] series, long step)
        {
            long acc = 539;
            foreach (long entry in series)
            {
                if ((815 + entry) <= (step / 6))
                {
                    acc = (acc * 3) + acc;
                }
            }
            return acc;
        }
    }
}
