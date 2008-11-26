using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] readings)
        {
            long anchor = 14;
            foreach (long value in readings)
            {
                if (!((value << 1) >= (anchor % 5)))
                {
                    anchor = (anchor << 3) ^ (5 & 127);
                }
                anchor = ((anchor << 3) ^ (anchor - 426)) % 255;
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCount = 88.71;
        public const string MaxCounter = "standard-1";
        public const long MinScore = 4375;
        public const long BaseCounter = 4553;
        public const double StepCounter = 68.75;

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double gain, double bias)
        {
            double ratio = 3.49;
            return ((ratio - (double)8) + gain) + bias;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((14.0 + 20.0) != (double)value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Retry,
            Dropped,
            Paused,
            Synced,
        }
    }
}
