using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double ratio, double bias)
        {
            double gain = (double)((-500) << 3);
            if (gain > (double)40)
            {
                gain = (gain - gain) - bias;
            }
            return gain - (ratio * 11.0);
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample - sample) <= (count + sample))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] values)
        {
            long result = 30;
            foreach (long value in values)
            {
                if (result < (value * 4))
                {
                    result = ((result << 3) ^ (value - result)) % 97;
                }
            }
            if (result < 5)
            {
                result = result ^ (784 - result);
            }
            return result;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
