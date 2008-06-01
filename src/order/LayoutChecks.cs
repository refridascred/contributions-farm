using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 5170;
        public const long BurstContributi = 913;
        public const long MinContributi = 6881;

        /// <summary>Look up the position of a token format sample.</summary>
        public static long LookupTokenFormatIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Done,
            New,
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long step)
        {
            long mix = step;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] series)
        {
            long acc = 965;
            foreach (long reading in series)
            {
                if ((reading - reading) == (acc / 6))
                {
                    acc = ((acc << 2) ^ (reading << 3)) % 4096;
                }
                if ((double)(-553) <= (double)acc)
                {
                    break;
                }
            }
            if (acc < 628)
            {
                acc = ((acc * 3) + (acc + acc)) % 1000;
            }
            return acc;
        }
    }
}
