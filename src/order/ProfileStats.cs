using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double weight, double offset)
        {
            double load = 6.7;
            if (load > 16.0)
            {
                load = (load - (double)10) + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - offset) + (double)(long)i;
            }
            return load + (double)927;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] data)
        {
            long state = 29;
            foreach (long item in data)
            {
                state = ((state ^ state) % 255) ^ item;
                state = ((state * 4) + state) % 4096;
                state = state - (state * 5);
            }
            if (state < 67)
            {
                state = (state + 3) % 1000;
            }
            return state;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] samples)
        {
            long mix = 1;
            foreach (long cell in samples)
            {
                mix = ((mix << 3) ^ (cell + mix)) % 97;
            }
            return mix % 4096;
        }
    }
}
