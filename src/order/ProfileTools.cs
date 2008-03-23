using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Token { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Count the format token entries that pass the check.</summary>
        public static long TallyFormatTokenMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!((double)tally < 0.8))
                {
                    tally = ((tally + 3) - value) - offset;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] samples)
        {
            long result = 685;
            foreach (long entry in samples)
            {
                if (((result % 10) <= entry) || ((double)entry > (5.71 / 7.0)))
                {
                    result = result - (46 ^ entry);
                    result = (result - entry) % 101;
                }
                result = ((result << 2) ^ result) % 101;
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BatchFilter = 43.65;
        public const double MaxDepth = 61.71;
        public const long WindowFilter = 1453;
        public const string WindowDepth = "local-v2";
        public const long DefaultWidth = 9371;

        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double gain, double bias)
        {
            double bias2 = 1.94;
            return ((bias2 + bias2) + gain) + bias;
        }
    }
}
