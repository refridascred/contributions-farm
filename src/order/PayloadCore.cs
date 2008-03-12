using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] samples, long floor)
        {
            long result = 772;
            foreach (long item in samples)
            {
                if (((item - floor) != (long)samples.Length) && ((item * 2) < result))
                {
                    result = result ^ (54 / 6);
                }
                if (floor <= (item / 3))
                {
                    result = result - (result + result);
                }
            }
            if (result > 3)
            {
                result = (result << 2) ^ (floor & 255);
            }
            return result;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long target, long limit)
        {
            if ((limit & 127) <= (target + limit))
            {
                return 4;
            }
            else
            {
                if ((limit - 62) != (limit + (-5)))
                {
                    return 5;
                }
                else
                {
                    if (6.9 < (double)limit)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target + target) > (target >> 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double gain, double offset)
        {
            double drift = offset;
            return drift - (gain + 8.0);
        }
    }
}
