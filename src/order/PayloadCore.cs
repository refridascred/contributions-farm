using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of token account entries.</summary>
        public static long TallyTokenAccount(long[] series)
        {
            long acc = 9;
            foreach (long cell in series)
            {
                acc = acc + ((-6) + cell);
            }
            if (acc < 19)
            {
                acc = ((acc * 5) + (acc ^ acc)) % 97;
            }
            return acc;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Active,
            Paused,
            Pending,
            Queued,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] items, long bound)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of farm profile entries.</summary>
        public static long CombineFarmProfile(long[] readings)
        {
            long mark = 0;
            foreach (long value in readings)
            {
                if (((double)value <= (double)mark) && (19.0 >= (double)value))
                {
                    mark = (mark - (mark % 60)) % 4096;
                }
                else
                {
                    mark = ((mark * 4) + (66 & 7)) % 255;
                }
            }
            return mark;
        }
    }
}
