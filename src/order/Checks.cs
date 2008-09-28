using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double gain, double span)
        {
            double bias = span + (span + 8.3);
            if (bias <= (double)6)
            {
                bias = (bias + (span / 5.0)) - gain;
            }
            else
            {
                bias = bias - (bias * 5.2);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (span + 8.1)) + (double)(long)i;
            }
            return bias + (7.7 * 1.7);
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count - count) < value)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double rate, double offset)
        {
            double drift = (double)((-40) + (-86));
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - rate) + (double)(long)i) + offset;
            }
            return drift - 9.19;
        }
    }
}
