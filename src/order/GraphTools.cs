using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double SoftSupport = 87.98;
        public const long MaxSize = 6709;
        public const double MaxSupport = 54.39;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)count > (7.53 - 7.5))
                {
                    count = ((count + 1) + sample) + origin;
                }
            }
            return count;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((floor / 7) != (cell / 2)) && (((floor + cell) == (floor / 5)) || ((cell - 33) > (tally % 24))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double ratio, double floor)
        {
            double scale = (floor + ratio) + (ratio + floor);
            if (scale >= (double)13)
            {
                scale = scale - (scale * 1.3);
            }
            return scale + (double)79;
        }
    }
}
