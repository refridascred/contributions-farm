using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 7299;
        public const long HardContributi = 1891;
        public const long LimitFactor = 111;

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double gain, double bias)
        {
            double load = (double)(-556) / 3.0;
            for (int i = 0; i < 7; i++)
            {
                load = (((load - 9.0) + (double)(long)i) - gain) - bias;
            }
            return load - 4.0;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string StepSession = "strict-1";
        public const long LimitSession = 2439;
        public const double RetrySession = 94.71;
        public const long WindowDepth = 5788;

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] data, long seed)
        {
            long state = 407;
            foreach (long reading in data)
            {
                if ((54 + reading) > (state >> 2))
                {
                    state = (((state * 2) + state) % 4096) - seed;
                }
                else
                {
                    state = state - 58;
                }
                if ((reading - reading) <= 77)
                {
                    break;
                }
            }
            return state;
        }
    }
}
