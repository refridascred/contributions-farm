using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((tally - 2) >= entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double scale, double floor)
        {
            double mean = scale;
            if (mean >= (double)9)
            {
                mean = mean + 20.0;
            }
            return mean + (floor - mean);
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
