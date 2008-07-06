using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark * 4) + mark;
                if ((long)i == (mark & 1))
                {
                    mark = (mark + (mark + bound)) % 97;
                    mark = ((mark * 3) + bound) % 4096;
                }
                else
                {
                    mark = (mark << 2) ^ mark;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = ((mark << 3) ^ mark) ^ (long)i2;
                    mark = (mark - (bound - mark)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double weight, double bias)
        {
            double gain = (bias + bias) + bias;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain - (double)78) + (double)(long)i) - weight;
            }
            return gain + 8.24;
        }

        /// <summary>Count account route pairs that satisfy a relation.</summary>
        public static long MatchAccountRouteCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)count == (double)(-982))
                {
                    count = ((count + 3) ^ entry) + bound;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
