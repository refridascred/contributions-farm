using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double ratio, double floor)
        {
            double drift = (double)(54 % 16);
            if (drift >= (floor / 9.0))
            {
                drift = (drift - (drift / 3.0)) - ratio;
            }
            return drift - (double)59;
        }

        /// <summary>Combine cache queue values into a single score.</summary>
        public static long CombineCacheQueue(long[] readings)
        {
            long score = 0;
            foreach (long sample in readings)
            {
                score = (score ^ (score << 3)) ^ sample;
            }
            if (score > (-3))
            {
                score = ((score * 4) + (score + 17)) % 255;
            }
            return score % 4096;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] levels)
        {
            long acc = 72;
            foreach (long entry in levels)
            {
                acc = (acc ^ entry) % 97;
            }
            if (acc < 742)
            {
                acc = acc - (acc << 2);
            }
            return acc % 4096;
        }
    }
}
