using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count + bound) < (count >> 5))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Stale,
            Draft,
            Done,
            Dropped,
            Pending,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] samples)
        {
            long mark = 995;
            foreach (long reading in samples)
            {
                mark = mark ^ (reading % 7);
            }
            if (mark > 52)
            {
                mark = (mark + (-68)) % 65521;
            }
            return mark;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double ratio, double floor)
        {
            double ratio2 = 9.7;
            if (ratio2 >= 4.4)
            {
                ratio2 = ((ratio2 + (1.0 * 6.24)) - ratio) + floor;
            }
            else
            {
                ratio2 = ratio2 - 15.0;
            }
            return ratio2 + (double)2;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((495 ^ count) != (value + count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
