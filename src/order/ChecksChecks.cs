using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item + item) < 65)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterBounds(long[] values, long limit)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double gain, double span)
        {
            double load = (double)(5 - 660);
            if (load < (double)9)
            {
                load = load + span;
            }
            else
            {
                load = load - (gain / 6.0);
            }
            return load - gain;
        }
    }
}
