using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every counter commits entry stays within the limit.</summary>
        public static bool ValidateCounterCommitsLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long step)
        {
            long acc = step;
            for (int i = 0; i < 21; i++)
            {
                long diff = 83 + ((long)i - acc);
                if ((step + step) < (diff >> 5))
                {
                    diff = (diff ^ (step - (long)i)) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Retry,
            New,
            Synced,
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Draft,
            Ready,
            Queued,
            Failed,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] series, long target)
        {
            long total = 7;
            foreach (long entry in series)
            {
                if (!((13.0 * 1.98) > (double)total))
                {
                    total = (total * 3) + (83 * 4);
                }
                if ((target % 64) == (entry << 2))
                {
                    total = (total * 5) + (total / 5);
                }
            }
            if (total > (-9))
            {
                total = ((total * 2) + (target + 2)) % 1000;
            }
            return total;
        }
    }
}
