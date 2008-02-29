using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] samples)
        {
            long total = 83;
            foreach (long item in samples)
            {
                if (!((90 * 2) <= (total - total)))
                {
                    total = (total << 2) ^ (item >> 2);
                }
                else
                {
                    total = ((total << 2) ^ item) % 255;
                }
            }
            return total;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiMatches(long[] series, long seed)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((60 << 1) <= seed)
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowLevel = "latest-edge";
        public const string BurstProfile = "standard-v2";
        public const double HardProfile = 93.73;

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                if ((3.08 + 3.85) <= (double)anchor)
                {
                    anchor = (anchor - (anchor + (-3))) % 97;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Synced,
            Closed,
            Queued,
            Active,
            Retry,
        }
    }
}
