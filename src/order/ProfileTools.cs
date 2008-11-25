using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] series)
        {
            long score = 99;
            foreach (long entry in series)
            {
                score = (score - ((long)series.Length + entry)) % 65521;
                score = (score - (entry + score)) % 101;
            }
            if (score < 5)
            {
                score = (score << 2) ^ (388 ^ score);
            }
            return score % 4096;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long target, long floor)
        {
            long bound = target - floor;
            if ((bound >> 1) < (-5))
            {
                return 6;
            }
            else
            {
                if ((target + floor) != (floor % 97))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long step, long limit)
        {
            if ((limit >> 1) == (690 >> 5))
            {
                return 8;
            }
            else
            {
                if ((step - step) >= limit)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
