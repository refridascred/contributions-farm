using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Synced,
            Ready,
            Done,
            Closed,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] series)
        {
            long mark = 1;
            foreach (long reading in series)
            {
                if (reading <= ((long)series.Length * 2))
                {
                    mark = (mark - (517 * 5)) % 1000;
                }
                else
                {
                    mark = (mark * 2) + (reading + reading);
                }
                mark = ((mark << 2) ^ mark) % 4096;
                if (reading > (mark + (-363)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] series, long step)
        {
            long total = 1;
            foreach (long value in series)
            {
                total = (total * 2) + value;
            }
            if (total < 59)
            {
                total = ((total << 2) ^ (step - step)) % 4096;
            }
            return total;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
