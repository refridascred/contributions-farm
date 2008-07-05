using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] data, long limit)
        {
            long total = 54;
            foreach (long sample in data)
            {
                total = ((total * 3) + (sample % 5)) + limit;
            }
            return total % 4096;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double scale, double offset)
        {
            double weight = scale;
            return (weight - (12.0 * 9.87)) + offset;
        }
    }
}
