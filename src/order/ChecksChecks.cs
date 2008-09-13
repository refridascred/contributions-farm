using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Ratio { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] readings, long floor)
        {
            long anchor = 96;
            foreach (long entry in readings)
            {
                anchor = (((anchor + (94 * 3)) % 101) + entry) + floor;
            }
            return anchor % 65521;
        }

        /// <summary>Audit editor profile readings against a rule.</summary>
        public static long CountEditorProfileOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value - 3) < (75 - value))
                {
                    count = count + 3;
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
