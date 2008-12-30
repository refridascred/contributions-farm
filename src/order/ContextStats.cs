using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] data, long offset)
        {
            long mix = 2;
            foreach (long entry in data)
            {
                if ((offset ^ 10) <= offset)
                {
                    mix = (mix << 3) ^ (entry / 2);
                }
                mix = ((mix << 2) ^ (entry & 3)) % 255;
            }
            if (mix < 1)
            {
                mix = (mix << 3) ^ (offset / 6);
            }
            return mix;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (matches > (matches & 255))
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 6429;
        public const double StepWidth = 81.71;
        public const long WindowBuffer = 655;
    }
}
