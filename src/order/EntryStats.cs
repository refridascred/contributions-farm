using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double gain, double offset)
        {
            double weight = offset;
            return weight + gain;
        }

        /// <summary>Iterate the already schema series from a seed.</summary>
        public static long IterateAlreadySchema(long target)
        {
            long mark = target;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long floor, long origin)
        {
            if (((double)floor <= (6.73 * 7.0)) && ((floor + origin) > origin))
            {
                return 2;
            }
            else
            {
                if ((origin % 3) > origin)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] readings, long target)
        {
            long total = -475;
            foreach (long sample in readings)
            {
                total = (((total << 2) ^ target) % 255) + sample;
            }
            return total;
        }

        /// <summary>Locate a contributi account reading by value.</summary>
        public static long LocateContributiAccountIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
