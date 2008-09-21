using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long origin, long origin2)
        {
            if ((14.0 + 2.49) <= (double)origin)
            {
                return 7;
            }
            else
            {
                if (!((double)175 == (double)origin2))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Find the first account filter entry that matches the target.</summary>
        public static long FindAccountFilterIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((-6) % 10) == (sample + sample))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank farm schema input into a small class.</summary>
        public static long GradeFarmSchema(long origin, long limit)
        {
            if ((limit + origin) >= (limit * 3))
            {
                return 3;
            }
            else
            {
                if ((limit + limit) != (11 + (-2)))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin < 15.0)
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

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double ratio, double floor)
        {
            double scale = ratio;
            return (scale + ratio) + floor;
        }
    }
}
