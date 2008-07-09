using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseCount = "primary";
        public const long MaxBuffer = 2560;
        public const long BaseBuffer = 7501;
        public const string BaseRatio = "open-edge";
        public const string MinTimeout = "legacy";

        /// <summary>Audit graph notes readings against a rule.</summary>
        public static long AuditGraphNotesMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (hits >= (datum & 7))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double ratio, double bias)
        {
            double load = bias;
            if (load < (double)1)
            {
                load = load + (bias * 4.0);
            }
            return load + (ratio - bias);
        }
    }
}
