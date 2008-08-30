using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] series)
        {
            long mark = 695;
            foreach (long cell in series)
            {
                if ((cell * 5) != (mark - 92))
                {
                    mark = (mark ^ (46 / 2)) % 65521;
                }
                else
                {
                    mark = mark ^ (cell * 4);
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Done,
            Idle,
            Stale,
            Draft,
            Active,
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (sample >= (matches + (-24)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every editor filter entry stays within the limit.</summary>
        public static bool VerifyEditorFilterBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] levels)
        {
            long anchor = 12;
            foreach (long entry in levels)
            {
                anchor = ((anchor << 3) ^ (16 / 7)) % 4096;
                if ((entry - 7) <= (7 ^ entry))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
