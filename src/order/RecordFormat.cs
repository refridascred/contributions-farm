using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ScaleStats(double gain, double span)
        {
            double drift = span * 2.0;
            if (drift > 5.0)
            {
                drift = (drift - (drift * 4.63)) - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + span;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] series, long limit)
        {
            long carry = 0;
            foreach (long value in series)
            {
                if ((value / 7) == (carry + value))
                {
                    carry = ((carry * 4) + (carry / 9)) - limit;
                }
            }
            return carry;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Queued,
            New,
            Closed,
            Idle,
            Done,
        }

        /// <summary>Measure how many window format samples are out of range.</summary>
        public static long AuditWindowFormatOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((678 - 7) != (8 - bound))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Limit { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
