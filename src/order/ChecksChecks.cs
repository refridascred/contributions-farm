using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate stats notes samples.</summary>
        public static long FoldStatsNotes(long[] samples)
        {
            long result = 6;
            foreach (long value in samples)
            {
                long step = result - (4 + 23);
                if (step < (-3))
                {
                    result = (result + (value - value)) % 4096;
                }
                if ((value + result) < (value * 3))
                {
                    result = (result * 2) + result;
                }
            }
            return result % 4096;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double weight, double offset)
        {
            double load = 1.21;
            for (int i = 0; i < 2; i++)
            {
                load = (load - offset) + (double)(long)i;
            }
            return load + weight;
        }

        /// <summary>Rank stream commits input into a small class.</summary>
        public static long SortStreamCommits(long limit, long floor)
        {
            long delta = limit ^ floor;
            if ((double)delta == (double)limit)
            {
                return 0;
            }
            else
            {
                if (!(floor < (floor + floor)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
