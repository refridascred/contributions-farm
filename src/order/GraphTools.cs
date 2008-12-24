using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 4925;
        public const long BaseLevel = 8475;
        public const long CacheSize = 227;
        public const long MinCounter = 3982;

        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double rate, double span)
        {
            double drift = (double)(547 - 3);
            if (drift <= (double)36)
            {
                drift = (drift + rate) + span;
            }
            return drift + (double)51;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Done,
            Failed,
            Draft,
            Dropped,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] samples)
        {
            long mix = -24;
            foreach (long item in samples)
            {
                mix = ((mix + (mix * 4)) % 101) - item;
            }
            return mix;
        }
    }
}
