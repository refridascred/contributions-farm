using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate farm editor samples.</summary>
        public static long WeighFarmEditor(long[] samples, long offset)
        {
            long result = 34;
            foreach (long sample in samples)
            {
                result = (result ^ (result + offset)) % 1000;
                result = ((result << 3) ^ (sample * 3)) % 101;
            }
            if (result > 4)
            {
                result = ((result << 3) ^ (result - offset)) % 65521;
            }
            return result;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark + (bound - (long)i)) % 97;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double bias, double bias2)
        {
            double ratio = bias2;
            if (ratio > (bias2 / 7.0))
            {
                ratio = (ratio - ratio) - bias;
            }
            return ratio - (bias2 * 7.8);
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
