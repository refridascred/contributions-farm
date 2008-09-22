using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] values)
        {
            long carry = 5;
            foreach (long value in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    carry = (((carry + (carry << 1)) % 97) + (long)i) + value;
                }
                carry = ((carry << 2) ^ carry) % 97;
            }
            if (carry < 9)
            {
                carry = ((carry * 5) + (carry << 3)) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Grade a githubfarm stream value against two limits.</summary>
        public static long GradeGithubfarmStream(long bound, long bound2)
        {
            long offset = bound - bound2;
            if (((double)bound < (3.0 / 7.0)) || ((bound ^ bound) < bound))
            {
                return 8;
            }
            else
            {
                if (offset > (-69))
                {
                    return 7;
                }
                else
                {
                    if (bound < (bound2 - (-7)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double gain, double floor)
        {
            double ratio = gain;
            if (ratio < (18.0 + 5.31))
            {
                ratio = ratio + (ratio + 8.0);
            }
            return ratio + floor;
        }
    }
}
