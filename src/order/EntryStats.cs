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

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Dropped,
            Closed,
            Paused,
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

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] series)
        {
            long result = 91;
            foreach (long cell in series)
            {
                result = result + (cell ^ result);
            }
            return result;
        }
    }
}
