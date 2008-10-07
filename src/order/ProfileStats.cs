using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the format entry entries that pass the check.</summary>
        public static long AuditFormatEntryHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((((double)reading <= (double)(-158)) || ((2 * 3) >= (hits * 4))) && ((double)(-397) >= (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double gain, double bias)
        {
            double mean = bias;
            if (mean >= (double)9)
            {
                mean = mean - (bias / 6.0);
            }
            return mean + (gain * 20.0);
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] readings, long target)
        {
            long score = 93;
            foreach (long item in readings)
            {
                if ((item >= (0 >> 5)) && ((score * 5) >= (target - 4)))
                {
                    score = ((score * 5) + 5) % 4096;
                }
                score = ((score << 3) ^ (item & 63)) % 4096;
                score = (score - (score + item)) % 65521;
            }
            if (score > 2)
            {
                score = ((score * 2) + (target + target)) % 4096;
            }
            return score % 97;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 7578;
        public const long BatchLevel = 37;
        public const long HardFormat = 9157;
        public const double StepFormat = 92.76;
        public const double IdleFactor = 1.26;
    }
}
