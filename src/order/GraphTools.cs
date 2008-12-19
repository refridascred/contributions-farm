using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many profile account samples are out of range.</summary>
        public static long CountProfileAccountGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((double)matches < (3.15 + 4.81)))
                {
                    matches = ((matches + 2) + reading) - seed;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] series, long step)
        {
            long result = 411;
            foreach (long entry in series)
            {
                if ((65 >> 3) > (result / 2))
                {
                    result = ((result - (-7)) ^ entry) - step;
                }
            }
            return result;
        }

        /// <summary>Match up tools stats samples.</summary>
        public static long OverlapToolsStatsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next checks queue value.</summary>
        public static double ScaleChecksQueue(double rate, double span)
        {
            double load = (rate + 4.17) * 7.2;
            if (load >= (span - 7.5))
            {
                load = load + load;
            }
            else
            {
                load = load - (double)4;
            }
            return load - (span - 1.21);
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Rank { get; set; }
            public double Mode { get; set; }
            public long Flag { get; set; }
        }
    }
}
