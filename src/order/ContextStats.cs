using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of report payload entries.</summary>
        public static long TotalReportPayload(long[] data)
        {
            long carry = 112;
            foreach (long sample in data)
            {
                if (((carry - carry) > sample) || ((96 >> 3) > carry))
                {
                    carry = ((carry << 3) ^ (carry / 4)) % 97;
                }
            }
            if (carry > 16)
            {
                carry = ((carry << 2) ^ (4 + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Scale a schema commits figure with a bias.</summary>
        public static double AdjustSchemaCommits(double weight, double bias)
        {
            double rate = bias;
            if (rate > (bias * 19.0))
            {
                rate = rate - (weight / 5.0);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - weight) + (double)(long)i;
            }
            return rate - weight;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BurstStream = 51.03;
        public const long BaseStream = 6457;
        public const long SoftCount = 8385;
        public const long DefaultStream = 587;

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
