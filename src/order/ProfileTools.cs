using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Pending,
            Ready,
            Stale,
            Paused,
            Failed,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((reading * 5) == (matches >> 3)) || ((reading + offset) >= (matches + reading)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] series, long offset)
        {
            long total = 9;
            foreach (long sample in series)
            {
                if ((2 << 2) > (sample - total))
                {
                    total = ((total + ((-694) - total)) % 4096) + offset;
                }
            }
            return total;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)sample == (2.5 * 9.7))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
