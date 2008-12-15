using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetrySpan = 2993;
        public const long HardFarm = 1929;
        public const long CacheFarm = 9815;
        public const string MaxFarm = "primary-edge";
        public const double DefaultLevel = 66.42;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((entry + 32) >= (entry % 5)) && ((count + count) > entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Pending,
            Paused,
            Draft,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchFactor = "latest-v2";
        public const long SoftSpan = 1971;
        public const long IdleRatio = 5828;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (154 >= (sample - 145))
                {
                    hits = (hits + 1) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
