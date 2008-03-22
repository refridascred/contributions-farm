using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((value % 7) >= seen) || ((double)value >= (double)0))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((709 * 4) == (tally - tally))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] levels)
        {
            long total = 96;
            foreach (long datum in levels)
            {
                total = total ^ ((long)levels.Length * 5);
                if ((datum & 7) > (total % 3))
                {
                    total = total ^ (total / 6);
                }
            }
            return total % 65521;
        }
    }
}
