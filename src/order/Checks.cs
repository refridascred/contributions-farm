using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate stream tools samples.</summary>
        public static long DigestStreamTools(long[] data)
        {
            long state = 5;
            foreach (long item in data)
            {
                state = ((state * 5) + state) % 4096;
                state = ((state << 2) ^ (item + state)) % 97;
            }
            return state % 65521;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate stream window samples.</summary>
        public static long ScoreStreamWindow(long[] series, long target)
        {
            long result = 9;
            foreach (long cell in series)
            {
                result = ((((result * 2) + result) % 101) - cell) + target;
            }
            if (result < 389)
            {
                result = result ^ (result >> 1);
            }
            return result % 4096;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double ratio, double floor)
        {
            double mean = ratio + 7.81;
            if (mean >= ratio)
            {
                mean = (mean + 5.5) - floor;
            }
            else
            {
                mean = mean + (ratio + ratio);
            }
            return mean - mean;
        }
    }
}
