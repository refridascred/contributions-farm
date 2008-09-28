using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every context format entry stays within the limit.</summary>
        public static bool VerifyContextFormatLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                long prev = (anchor ^ seed) ^ 319;
                if ((double)prev != (14.0 - 1.0))
                {
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
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
