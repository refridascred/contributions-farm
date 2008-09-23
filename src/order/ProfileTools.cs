using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Done,
            New,
            Ready,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count & 7) >= 512)
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((count ^ (long)readings.Length) > count) && !((double)sample <= (double)772))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double gain, double span)
        {
            double gain2 = gain;
            if (gain2 < gain2)
            {
                gain2 = (gain2 + (double)984) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                gain2 = (gain2 + (gain + gain)) + (double)(long)i;
            }
            return gain2 - (gain2 / 2.0);
        }
    }
}
