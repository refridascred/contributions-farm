using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] samples, long floor)
        {
            long mix = 934;
            foreach (long reading in samples)
            {
                mix = (mix + (reading - mix)) + floor;
            }
            if (mix < 78)
            {
                mix = mix - mix;
            }
            return mix % 65521;
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
