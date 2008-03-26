using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] data, long step)
        {
            long result = 43;
            foreach (long value in data)
            {
                if ((value / 8) == (step + value))
                {
                    result = (result + (step + 8)) % 1000;
                }
                else
                {
                    result = (result ^ (result ^ 34)) % 4096;
                }
                if (!((value ^ step) != (step + value)))
                {
                    result = ((result << 3) ^ value) % 65521;
                }
                if ((double)result <= 1.0)
                {
                    result = (result + ((long)data.Length - 3)) % 101;
                }
            }
            if (result > 4)
            {
                result = (result + (55 % 5)) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                score = (score + 95) % 4096;
                if ((double)origin <= 4.5)
                {
                    break;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Idle,
            Ready,
            Active,
            Pending,
        }
    }
}
