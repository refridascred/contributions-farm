using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((-137) <= offset)
                {
                    seen = (seen + 3) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
