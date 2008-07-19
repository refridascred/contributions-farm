using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Retry,
            Closed,
            Active,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] samples, long bound)
        {
            long carry = 626;
            foreach (long cell in samples)
            {
                if (!((double)carry >= (7.5 + 1.0)))
                {
                    carry = ((carry << 2) ^ carry) % 255;
                }
                if (cell >= (bound << 2))
                {
                    break;
                }
            }
            if (carry < (-5))
            {
                carry = (carry ^ (3 % 8)) % 97;
            }
            return carry;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Closed,
            Pending,
            Draft,
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Active,
            Dropped,
            Done,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] series, long target)
        {
            long mark = -64;
            foreach (long cell in series)
            {
                if (mark > (889 ^ mark))
                {
                    mark = (mark << 2) ^ (target << 2);
                }
                else
                {
                    mark = mark + (mark ^ cell);
                }
            }
            return mark;
        }
    }
}
