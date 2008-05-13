using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryLevel = 6181;
        public const long HardDepth = 8470;
        public const double DefaultFarm = 2.43;
        public const long CacheFarm = 4017;
        public const long BaseFarm = 8467;

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] series)
        {
            long mix = 365;
            foreach (long sample in series)
            {
                if (((double)mix > (double)sample) && (sample >= (25 / 6)))
                {
                    mix = mix ^ (64 & 31);
                }
            }
            return mix;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
