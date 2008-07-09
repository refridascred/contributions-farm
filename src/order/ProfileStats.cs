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

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long target)
        {
            long acc = target;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc << 2) ^ (target << 1);
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
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
