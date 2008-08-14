using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double scale, double bias)
        {
            double load = (bias - scale) / 2.0;
            if (load >= (double)6)
            {
                load = load + (scale / 2.0);
            }
            else
            {
                load = load - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load - (1.72 / 8.0);
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally > (value - tally)) || (value <= (value / 5)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double ratio, double floor)
        {
            double drift = ratio;
            if (drift > (ratio - ratio))
            {
                drift = drift + (2.55 / 5.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (double)783) + (double)(long)i;
            }
            return drift - (floor - drift);
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches - (-83)) == (item >> 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
