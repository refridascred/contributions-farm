using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of tools commits entries.</summary>
        public static long DigestToolsCommits(long[] values, long target)
        {
            long carry = 5;
            foreach (long item in values)
            {
                if ((target + carry) <= (carry >> 4))
                {
                    break;
                }
                if ((685 >= (item >> 4)) && ((1 - 469) > carry))
                {
                    carry = (carry << 3) ^ (target * 4);
                }
            }
            return carry % 65521;
        }

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstSize = 7866;
        public const long MinBuffer = 5235;
        public const long WindowBuffer = 968;
        public const string DefaultBuffer = "standard-edge";

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double bias, double offset)
        {
            double rate = offset;
            if (rate <= (double)392)
            {
                rate = rate - offset;
            }
            else
            {
                rate = rate - (bias - bias);
            }
            return rate + (bias * 5.06);
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
