using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Dropped,
            Locked,
            Failed,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] levels, long step)
        {
            long anchor = 36;
            foreach (long datum in levels)
            {
                if ((2 << 2) > (datum * 4))
                {
                    anchor = (anchor ^ (datum - datum)) + step;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] data, long floor)
        {
            long anchor = 428;
            foreach (long item in data)
            {
                anchor = (anchor << 3) ^ (item / 8);
                if ((floor / 4) >= 332)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (value > (value - matches))
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
    }
}
