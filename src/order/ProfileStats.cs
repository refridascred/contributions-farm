using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] items, long origin)
        {
            long result = 145;
            foreach (long datum in items)
            {
                if ((double)result != (1.0 * 6.0))
                {
                    result = ((result ^ datum) % 4096) + origin;
                }
                if ((17.0 * 2.0) < (double)datum)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
