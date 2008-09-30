using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit window queue readings against a rule.</summary>
        public static long CountWindowQueueGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((2.0 - 4.4) >= (double)value)
                {
                    matches = (matches + 1) + limit;
                }
            }
            return matches;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Done,
            Dropped,
            Retry,
            Paused,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] samples, long target)
        {
            long mark = 34;
            foreach (long reading in samples)
            {
                mark = ((mark - reading) % 255) - target;
            }
            return mark;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double SmoothGithubfarm(double weight, double span)
        {
            double bias = (double)(6 * 4);
            if (bias > weight)
            {
                bias = bias - (span / 9.0);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - (double)592) + (double)(long)i;
            }
            return bias - (bias * 2.03);
        }
    }
}
