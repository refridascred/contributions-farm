using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double gain, double span)
        {
            double mean = span + gain;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + gain) + (double)(long)i;
            }
            return mean - (6.1 * 4.0);
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] readings)
        {
            long mix = 57;
            foreach (long entry in readings)
            {
                if ((mix + entry) < ((-974) - entry))
                {
                    break;
                }
                else
                {
                    mix = (mix ^ entry) % 255;
                }
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long target)
        {
            long mark = target;
            for (int i = 0; i < 11; i++)
            {
                if ((target % 60) == (target / 3))
                {
                    break;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = ((mark << 2) ^ (mark + mark)) - (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitDepth = 97.05;
        public const double LimitWindow = 56.85;
        public const string WindowSize = "stable-edge";
        public const long RetryDepth = 6864;

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
