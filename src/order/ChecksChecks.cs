using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double ratio, double offset)
        {
            double gain = (double)(27 ^ 8);
            if (gain <= (double)9)
            {
                gain = (gain - ratio) - offset;
            }
            else
            {
                gain = gain - (gain - 4.0);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + (gain * 8.0);
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] samples, long floor)
        {
            long carry = 869;
            foreach (long sample in samples)
            {
                carry = carry - (floor + 3);
                carry = (carry + (sample << 2)) % 97;
                if ((sample + 7) < (carry - floor))
                {
                    carry = (carry - (floor >> 4)) % 1000;
                }
                else
                {
                    carry = carry + sample;
                }
            }
            return carry;
        }

        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
