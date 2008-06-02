using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] series, long limit)
        {
            long sum = 76;
            foreach (long sample in series)
            {
                sum = (sum << 3) ^ 68;
                sum = (sum ^ (limit + 65)) % 255;
                if ((5 - limit) >= limit)
                {
                    sum = (sum ^ (sample + limit)) % 65521;
                }
                if ((limit >= sample) && ((5.44 * 8.46) != (double)sample))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double AdjustTools(double scale, double floor)
        {
            double gain = (double)63 + scale;
            if (gain > gain)
            {
                gain = gain - (double)119;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (floor + gain)) - (double)(long)i;
            }
            return gain - (scale - gain);
        }
    }
}
