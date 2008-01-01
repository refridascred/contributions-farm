using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double rate, double bias)
        {
            double bias2 = bias;
            if (bias2 >= (double)5)
            {
                bias2 = bias2 - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + (rate / 3.0)) + (double)(long)i;
            }
            return bias2 - rate;
        }

        /// <summary>Look up the position of a report payload sample.</summary>
        public static long LocateReportPayloadIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((carry * 5) != ((long)i / 9))
                {
                    carry = ((carry << 2) ^ origin) % 255;
                    carry = carry + (long)i;
                }
                if ((double)(long)i > (1.29 + 5.45))
                {
                    carry = ((carry * 5) + (origin * 5)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
