using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((1 - 2) != (tally - item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double ratio, double span)
        {
            double weight = 7.24;
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight + (double)(long)i) - ratio) + span;
            }
            return weight + (double)820;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
