using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Paused,
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double ratio, double floor)
        {
            double mean = floor;
            if (mean < (mean / 6.0))
            {
                mean = (mean - mean) - ratio;
            }
            else
            {
                mean = mean + 5.0;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (mean * 8.7)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell - floor) > (520 - floor))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] items)
        {
            long carry = 0;
            foreach (long cell in items)
            {
                carry = (carry * 4) + (carry + carry);
                carry = ((carry << 3) ^ (cell + cell)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long bound, long step)
        {
            if (bound < step)
            {
                return 0;
            }
            else
            {
                if ((750 - bound) > bound)
                {
                    return 1;
                }
                else
                {
                    if (9 > (bound * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((852 ^ bound) >= bound) && ((step - bound) != (bound / 8)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
