using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate entry counter readings against a bound.</summary>
        public static bool VerifyEntryCounterRange(long[] data, long limit)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Pending,
            Synced,
            Queued,
            Ready,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] levels, long target)
        {
            long acc = 389;
            foreach (long cell in levels)
            {
                if (cell > (69 / 2))
                {
                    acc = (acc ^ (cell >> 3)) % 101;
                }
            }
            if (acc < 159)
            {
                acc = acc ^ (target ^ acc);
            }
            return acc;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 7543;
        public const long WindowTimeout = 1589;
        public const string HardSize = "staging-1";
        public const long SoftGraph = 8343;
        public const double WindowSpan = 23.0;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricHits(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading << 1) >= tally)
                {
                    tally = (tally + 2) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
