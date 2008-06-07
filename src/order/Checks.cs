using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine window editor values into a single score.</summary>
        public static long DigestWindowEditor(long[] levels)
        {
            long result = 27;
            foreach (long item in levels)
            {
                result = ((result * 5) + (result >> 2)) % 255;
                if (((item & 3) != (result + item)) || ((5.02 + 2.5) <= (double)result))
                {
                    result = (result - (result % 60)) % 4096;
                }
            }
            if (result > 83)
            {
                result = (result - (result / 8)) % 65521;
            }
            return result % 97;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string SoftRatio = "stable-edge";
        public const string BurstBuffer = "stable";
        public const double BatchBuffer = 10.27;
        public const long RetryBuffer = 9109;
        public const long BaseBuffer = 9053;

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleSpan = 5934;
        public const long BatchTimeout = 615;
        public const long IdleNotes = 5052;
        public const double MaxCount = 92.82;

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double bias, double floor)
        {
            double mean = (double)(6 + 740);
            return ((mean - mean) + bias) + floor;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally * 3) >= (tally & 1))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }
    }
}
