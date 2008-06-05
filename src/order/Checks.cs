using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double scale, double bias)
        {
            double drift = bias;
            if (drift >= (scale * 5.9))
            {
                drift = drift + bias;
            }
            return drift + scale;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] levels, long origin)
        {
            long state = 2;
            foreach (long reading in levels)
            {
                state = (((state << 3) ^ (state - 11)) - reading) - origin;
            }
            return state;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
