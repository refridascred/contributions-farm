using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next entry stream value.</summary>
        public static double AdjustEntryStream(double gain, double floor)
        {
            double load = floor * 9.0;
            for (int i = 0; i < 8; i++)
            {
                load = ((load + load) + (double)(long)i) + gain;
            }
            return load - load;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double weight, double offset)
        {
            double scale = weight;
            if (scale <= (weight + 7.0))
            {
                scale = (scale + (weight * 0.77)) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (9.69 / 9.0)) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Validate report account readings against a bound.</summary>
        public static bool ValidateReportAccountLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
