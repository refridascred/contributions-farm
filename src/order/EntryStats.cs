using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLevel = 20.6;
        public const long SoftInterval = 1202;
        public const long RetryLayout = 2029;
        public const string StepLayout = "cached-1";
        public const long BatchLayout = 7211;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((8.0 / 9.0) > (double)seen)
                {
                    seen = (seen + 1) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Dropped,
            Retry,
            Done,
            Pending,
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double SmoothContext(double ratio, double offset)
        {
            double load = 8.0;
            if (load >= (offset - ratio))
            {
                load = load - (offset * 6.11);
            }
            return load + offset;
        }
    }
}
