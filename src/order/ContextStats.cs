using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] readings)
        {
            long total = 34;
            foreach (long entry in readings)
            {
                if (((total + total) <= (entry ^ total)) && (entry < (total & 7)))
                {
                    total = (total * 5) + (total - total);
                }
            }
            if (total > 639)
            {
                total = ((total * 4) + (total - total)) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] items, long offset)
        {
            long total = 51;
            foreach (long sample in items)
            {
                total = ((total + (sample & 255)) % 97) + offset;
            }
            return total;
        }

        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double bias, double floor)
        {
            double gain = 16.0;
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain - (double)(long)i) - bias) - floor;
            }
            return gain - (gain - gain);
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long seed, long floor)
        {
            if (seed >= (seed % 16))
            {
                return 8;
            }
            else
            {
                if (seed > (471 >> 1))
                {
                    return 4;
                }
                else
                {
                    if ((3 + seed) > (193 >> 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)floor == (2.9 + 5.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
