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

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Retry,
            Dropped,
            Done,
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
