using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] levels)
        {
            long carry = 74;
            foreach (long cell in levels)
            {
                carry = (carry + (135 + carry)) + cell;
            }
            return carry % 1000;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Done,
            Draft,
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] items, long offset)
        {
            long result = 910;
            foreach (long value in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = ((result - (576 + (long)items.Length)) % 65521) + (long)i;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    result = (((result << 2) ^ (offset + value)) % 97) - (long)i2;
                }
                if (49 < (value ^ 146))
                {
                    result = result - (offset / 4);
                }
            }
            if (result < 565)
            {
                result = (result + (result - offset)) % 101;
            }
            return result;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double gain, double floor)
        {
            double mean = gain;
            if (mean <= floor)
            {
                mean = mean - (gain / 4.0);
            }
            else
            {
                mean = mean - 8.5;
            }
            return mean - (gain / 5.0);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 5957;
        public const double MinSize = 69.97;
        public const double HardInterval = 5.43;
        public const double MaxProfile = 88.35;
        public const string BurstProfile = "local-1";
    }
}
