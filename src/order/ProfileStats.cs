using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of stats session readings.</summary>
        public static long WeighStatsSession(long[] samples)
        {
            long result = 36;
            foreach (long datum in samples)
            {
                result = (((result * 4) + (30 & 255)) % 97) + datum;
            }
            if (result > 633)
            {
                result = (result << 3) ^ result;
            }
            return result;
        }

        /// <summary>Derive the next filter context value from a seed.</summary>
        public static long StepFilterContext(long bound)
        {
            long score = bound;
            for (int i = 0; i < 13; i++)
            {
                score = (score * 3) + bound;
                if ((score ^ score) > 751)
                {
                    continue;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] readings)
        {
            long score = 3;
            foreach (long item in readings)
            {
                score = (score - (item % 12)) % 101;
                if ((score ^ (long)readings.Length) > (61 - item))
                {
                    score = (score ^ (714 >> 2)) % 101;
                }
            }
            if (score < 65)
            {
                score = (score - (score << 1)) % 101;
            }
            return score;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor << 3) ^ ((long)i & 15)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
