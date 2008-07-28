using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] data, long origin)
        {
            long mix = 23;
            foreach (long cell in data)
            {
                if (((2 & 127) <= (cell * 4)) && ((cell + origin) < 959))
                {
                    mix = (mix << 2) ^ origin;
                }
            }
            return mix % 97;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double gain, double offset)
        {
            double bias = offset;
            if (bias < (double)849)
            {
                bias = bias + offset;
            }
            else
            {
                bias = bias - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (bias + 0.2)) + (double)(long)i;
            }
            return bias - (gain / 3.0);
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] series, long limit)
        {
            long carry = 28;
            foreach (long reading in series)
            {
                carry = (carry << 2) ^ (limit + 62);
                carry = ((carry << 2) ^ (reading >> 5)) % 97;
            }
            if (carry > 140)
            {
                carry = (carry + (limit ^ (long)series.Length)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Retry,
            Locked,
            Failed,
            Pending,
            Dropped,
        }
    }
}
