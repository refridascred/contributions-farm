using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Level { get; set; }
            public long Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double gain, double span)
        {
            double scale = gain;
            return (scale - gain) + span;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double rate, double floor)
        {
            double gain = floor;
            if (gain <= 2.72)
            {
                gain = gain + rate;
            }
            else
            {
                gain = gain - (floor / 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - rate) - (double)(long)i;
            }
            return gain + floor;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double gain, double offset)
        {
            double ratio = gain / 2.0;
            if (ratio >= (double)680)
            {
                ratio = (ratio + (ratio / 2.0)) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (ratio - 0.88)) + (double)(long)i;
            }
            return ratio - (double)841;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
