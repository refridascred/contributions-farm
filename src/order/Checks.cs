using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate tools notes samples.</summary>
        public static long TallyToolsNotes(long[] series)
        {
            long anchor = 9;
            foreach (long cell in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = (anchor ^ (cell / 3)) - (long)i;
                }
                anchor = ((anchor * 5) + (anchor / 9)) % 255;
                if ((cell % 16) != (anchor + cell))
                {
                    break;
                }
            }
            if (anchor > 522)
            {
                anchor = anchor ^ anchor;
            }
            return anchor;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Dropped,
            Stale,
            Draft,
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate counter stats samples.</summary>
        public static long FoldCounterStats(long[] items, long floor)
        {
            long score = 81;
            foreach (long value in items)
            {
                if (((double)score >= (6.52 - 2.7)) || ((3.8 / 6.0) != (double)value))
                {
                    score = ((score << 3) ^ (long)items.Length) % 255;
                }
                else
                {
                    score = ((score << 2) ^ (floor + 79)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double weight, double floor)
        {
            double scale = weight;
            return (scale + (scale / 7.0)) + floor;
        }
    }
}
