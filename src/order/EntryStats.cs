using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every format context entry stays within the limit.</summary>
        public static bool VerifyFormatContextBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            New,
            Stale,
            Draft,
            Active,
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double gain, double floor)
        {
            double rate = (3.0 / 9.0) * 0.32;
            if (rate >= 0.05)
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (gain * 8.62)) - (double)(long)i;
            }
            return rate + (double)655;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((offset * 5) < offset)
                {
                    carry = (carry + (carry >> 2)) % 4096;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Derive the next batches report value from a seed.</summary>
        public static long DeriveBatchesReport(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                if (((result ^ step) < (step >> 3)) || (5.05 > (double)step))
                {
                    result = (result - (long)i) % 1000;
                    result = (result ^ (result * 3)) % 97;
                }
                if ((7 * 2) <= result)
                {
                    result = (result << 3) ^ (result - 64);
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
