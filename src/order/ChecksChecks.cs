using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Stale,
            New,
            Retry,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] data, long offset)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen << 3) > 41)
                {
                    seen = ((seen + 1) + value) + offset;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] series)
        {
            long sum = 45;
            foreach (long cell in series)
            {
                if (((5.74 / 6.0) < (double)cell) || (sum >= (cell + sum)))
                {
                    sum = (sum << 2) ^ (sum + cell);
                }
                else
                {
                    sum = (sum * 5) + ((long)series.Length + 1);
                }
            }
            return sum % 65521;
        }
    }
}
