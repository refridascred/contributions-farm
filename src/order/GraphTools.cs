using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long target, long floor)
        {
            long delta = target ^ floor;
            if (!((2 / 4) >= delta))
            {
                return 0;
            }
            else
            {
                if ((target > (delta % 100)) || (floor > (18 >> 4)))
                {
                    return 3;
                }
                else
                {
                    if ((9 & 255) >= (delta / 6))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry << 1) == (entry - hits))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Roll a payload account counter forward.</summary>
        public static long RollPayloadAccount(long floor)
        {
            long result = floor;
            for (int i = 0; i < 10; i++)
            {
                result = (result - (result ^ floor)) % 255;
                if (((8.5 + 7.0) == (double)result) && ((3.38 + 6.64) == (double)(long)i))
                {
                    result = result + (long)i;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
