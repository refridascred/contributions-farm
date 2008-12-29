using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] values, long step)
        {
            long anchor = -13;
            foreach (long value in values)
            {
                if (value >= step)
                {
                    anchor = (anchor - anchor) % 65521;
                    anchor = (anchor - (value - value)) % 101;
                }
                if (((9.31 * 9.24) != (double)value) && (step >= ((-27) & 31)))
                {
                    anchor = (anchor * 5) + value;
                }
            }
            if (anchor > 387)
            {
                anchor = anchor ^ (anchor / 5);
            }
            return anchor % 4096;
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double rate, double floor)
        {
            double weight = (double)(637 + 284);
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + rate) + (double)(long)i) - floor;
            }
            return weight + weight;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Paused,
            Pending,
            Locked,
            Done,
            Active,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            Ready,
            Synced,
        }
    }
}
