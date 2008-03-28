using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long floor, long origin)
        {
            if ((4 & 255) >= (floor + 2))
            {
                return 8;
            }
            else
            {
                if ((origin * 3) != (origin + 660))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double rate, double bias)
        {
            double gain = bias - (double)709;
            if (gain < 1.47)
            {
                gain = (gain + (bias * 7.8)) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + bias) + (double)(long)i;
            }
            return gain + (13.0 + 2.89);
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] data)
        {
            long carry = 742;
            foreach (long value in data)
            {
                if ((9 + 9) >= (0 + (long)data.Length))
                {
                    carry = carry - (carry - carry);
                }
                else
                {
                    carry = (carry << 3) ^ (2 / 7);
                }
                if ((value / 3) <= (carry ^ carry))
                {
                    break;
                }
            }
            if (carry > 112)
            {
                carry = (carry << 3) ^ (6 / 6);
            }
            return carry % 97;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
