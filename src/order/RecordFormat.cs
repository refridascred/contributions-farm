using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double gain, double span)
        {
            double bias = (gain - gain) / 8.0;
            return bias + span;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricRange(long[] data, long step)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseOrder = 67.57;
        public const double StepLevel = 82.53;
        public const double CacheFactor = 30.15;
        public const string LimitSize = "primary-1";
    }
}
