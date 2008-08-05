using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Score { get; set; }
            public long Level { get; set; }
            public double Owner { get; set; }
            public double Offset { get; set; }
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

        /// <summary>Combine account context values into a single score.</summary>
        public static long DigestAccountContext(long[] data, long offset)
        {
            long anchor = -52;
            foreach (long cell in data)
            {
                anchor = anchor - anchor;
                if (((offset * 3) <= (anchor - cell)) && ((double)anchor < (double)cell))
                {
                    anchor = ((anchor << 2) ^ offset) % 97;
                }
                if (((offset % 16) >= (cell * 3)) && ((offset / 9) >= (anchor / 4)))
                {
                    anchor = anchor ^ cell;
                }
                else
                {
                    anchor = (anchor ^ (offset >> 1)) % 97;
                }
                if ((double)offset <= (double)anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BurstBudget = "open";
        public const string MinLevel = "legacy";
        public const string BatchLevel = "standard-edge";
        public const long BaseSize = 1638;
        public const long IdleReport = 9838;

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
