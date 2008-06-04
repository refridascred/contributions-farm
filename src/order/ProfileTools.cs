using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string MinWidth = "legacy-edge";
        public const double MinDepth = 77.55;
        public const long CacheSession = 7090;

        /// <summary>Audit command stream readings against a rule.</summary>
        public static long TallyCommandStreamHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((double)reading <= (7.18 + 5.07))
                {
                    matches = (matches + 1) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double ratio, double span)
        {
            double drift = ratio * 0.26;
            if (drift > 13.0)
            {
                drift = drift + span;
            }
            else
            {
                drift = drift + (drift * 6.9);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (16.0 + ratio)) + (double)(long)i;
            }
            return drift - (ratio + span);
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
