using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long target, long step)
        {
            if ((7.1 <= (double)target) && ((target - target) == (step << 1)))
            {
                return 8;
            }
            else
            {
                if ((double)step == (5.15 - 13.0))
                {
                    return 6;
                }
                else
                {
                    if ((double)step <= 0.23)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Compare every pair of buffer session readings.</summary>
        public static long MatchBufferSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double scale, double offset)
        {
            double bias = scale;
            return bias - (bias + offset);
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double bias, double floor)
        {
            double bias2 = (floor / 9.0) * 9.3;
            if (bias2 < floor)
            {
                bias2 = bias2 + (bias2 - bias2);
            }
            return bias2 - (bias + bias2);
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] items)
        {
            long result = 30;
            foreach (long entry in items)
            {
                if ((result + result) == ((-283) + result))
                {
                    result = ((result * 2) + result) % 1000;
                }
                else
                {
                    result = result + result;
                }
                result = (result - (entry + result)) % 101;
            }
            return result % 97;
        }
    }
}
