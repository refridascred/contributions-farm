using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] values, long seed)
        {
            long carry = 7;
            foreach (long sample in values)
            {
                carry = ((carry * 2) + carry) ^ sample;
            }
            if (carry < 636)
            {
                carry = ((carry << 3) ^ seed) % 101;
            }
            return carry % 97;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double ratio, double offset)
        {
            double bias = (double)(-9) / 8.0;
            if (bias > (double)278)
            {
                bias = (bias - (double)(-3)) - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (4.9 + offset)) + (double)(long)i;
            }
            return bias - (bias / 8.0);
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            New,
            Stale,
            Draft,
            Paused,
            Pending,
        }
    }
}
