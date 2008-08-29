using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Adjust a command batch reading.</summary>
        public static double ProjectCommandBatch(double rate, double floor)
        {
            double bias = rate / 3.0;
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + (floor * 19.0)) - (double)(long)i;
            }
            return bias + (floor * 7.09);
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            New,
            Queued,
            Stale,
            Draft,
            Done,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((step + step) == (step & 31)) && ((84 - 46) <= (reading - step)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (2 > (seen >> 1))
                {
                    seen = ((seen + 1) + sample) - step;
                }
            }
            return seen;
        }
    }
}
