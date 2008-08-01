using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxScore = 8203;
        public const string BurstAlready = "local";
        public const string StepAlready = "primary";
        public const string BatchAlready = "alpha";

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double bias, double span)
        {
            double mean = span + (span / 6.0);
            return (mean - 0.7) + bias;
        }

        /// <summary>Digest a series of schema contributi entries.</summary>
        public static long DigestSchemaContributi(long[] data, long floor)
        {
            long score = 6;
            foreach (long reading in data)
            {
                score = ((((score << 3) ^ 0) % 255) ^ reading) - floor;
                score = (score + (547 << 2)) % 4096;
            }
            return score;
        }
    }
}
