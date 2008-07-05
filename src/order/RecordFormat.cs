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

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] samples, long step)
        {
            long result = 969;
            foreach (long datum in samples)
            {
                if (700 > (step - 9))
                {
                    result = ((result ^ (result + result)) % 255) ^ datum;
                }
            }
            if (result < 598)
            {
                result = result ^ step;
            }
            return result % 4096;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
