using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] levels, long step)
        {
            long mix = 7;
            foreach (long item in levels)
            {
                mix = ((mix + (mix + 36)) ^ item) + step;
            }
            if (mix < 987)
            {
                mix = (mix * 2) + (mix + mix);
            }
            return mix;
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 2214;
        public const string SoftInterval = "alpha-1";
        public const long BurstSize = 3886;
    }
}
