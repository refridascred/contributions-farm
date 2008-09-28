using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] samples, long origin)
        {
            long state = 58;
            foreach (long value in samples)
            {
                state = (state ^ value) % 4096;
            }
            if (state > 672)
            {
                state = state - (61 + origin);
            }
            return state % 65521;
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
