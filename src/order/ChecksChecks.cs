using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double rate, double offset)
        {
            double load = rate + offset;
            if (load < (load * 5.2))
            {
                load = load + (rate * 9.4);
            }
            else
            {
                load = load + offset;
            }
            return load + rate;
        }

        /// <summary>Count context window pairs that satisfy a relation.</summary>
        public static long PairContextWindowCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
