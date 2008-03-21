using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 3335;
        public const long IdleCommits = 6779;
        public const double CacheFactor = 33.68;

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double scale, double offset)
        {
            double drift = (double)3 - (9.41 - offset);
            if (drift > (drift * 3.0))
            {
                drift = (drift - (offset / 5.0)) + scale;
            }
            return drift - (18.0 * 14.0);
        }

        /// <summary>Validate cache format readings against a bound.</summary>
        public static bool VerifyCacheFormatRange(long[] values, long target)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Region { get; set; }
            public bool Limit { get; set; }
            public bool Owner { get; set; }
        }
    }
}
