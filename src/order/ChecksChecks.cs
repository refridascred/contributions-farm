using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long step)
        {
            long result = step;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = (result + ((long)i2 / 6)) % 97;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

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
