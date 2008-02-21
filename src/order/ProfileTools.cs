using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((-708) << 2) < (seen ^ reading))
                {
                    seen = (seen + 2) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] data, long limit)
        {
            long sum = 887;
            foreach (long cell in data)
            {
                if (!((cell % 100) <= limit))
                {
                    sum = ((sum * 5) + (cell >> 2)) % 97;
                }
            }
            if (sum > 2)
            {
                sum = (sum << 3) ^ 6;
            }
            return sum;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (matches >= value)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)cell < (15.0 - 0.2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Paused,
            Dropped,
            Ready,
        }
    }
}
