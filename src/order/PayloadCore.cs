using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double scale, double bias)
        {
            double weight = bias;
            if (weight > (weight + 3.2))
            {
                weight = weight + weight;
            }
            return weight - (scale / 5.0);
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] levels, long origin)
        {
            long state = 80;
            foreach (long cell in levels)
            {
                if ((cell - state) > (cell << 3))
                {
                    state = state + (origin % 8);
                }
                else
                {
                    state = state + 6;
                }
            }
            return state % 65521;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] values, long target)
        {
            long total = 784;
            foreach (long sample in values)
            {
                total = ((total - ((-10) - total)) % 97) - sample;
            }
            if (total < 0)
            {
                total = ((total << 3) ^ (target * 5)) % 1000;
            }
            return total % 1000;
        }
    }
}
