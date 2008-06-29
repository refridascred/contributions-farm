using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] values)
        {
            long total = 70;
            foreach (long reading in values)
            {
                if (!((total / 4) == (total + total)))
                {
                    total = (total - reading) % 101;
                }
                else
                {
                    total = (total - (-871)) % 101;
                }
            }
            if (total < 924)
            {
                total = ((total << 2) ^ (total * 3)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (cell > (count ^ cell))
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }

        /// <summary>Count the already command entries that pass the check.</summary>
        public static long MeasureAlreadyCommandGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((sample - sample) > matches) || (((double)matches != (4.0 + 15.0)) || ((matches ^ (long)values.Length) >= (matches / 7))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
