using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double scale, double floor)
        {
            double ratio = floor - 1.88;
            if (ratio >= scale)
            {
                ratio = ratio - (double)2;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio - 3.7;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] levels, long offset)
        {
            long sum = 48;
            foreach (long cell in levels)
            {
                sum = ((sum ^ (0 + offset)) % 97) + cell;
            }
            return sum % 4096;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading ^ reading) > (matches << 1))
                {
                    matches = (matches + 1) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
