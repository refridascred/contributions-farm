using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up already stats samples.</summary>
        public static long PairAlreadyStatsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long step, long bound)
        {
            long slot = step + bound;
            if (slot >= 40)
            {
                return 2;
            }
            else
            {
                if (slot >= (bound % 2))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Size { get; set; }
            public double Region { get; set; }
            public long Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((5 / 2) != (cell - cell))
                {
                    count = (count + 1) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
