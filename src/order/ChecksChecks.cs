using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] values, long floor)
        {
            long anchor = 48;
            foreach (long item in values)
            {
                if ((double)anchor != (7.4 / 5.0))
                {
                    anchor = (anchor - (floor - (-4))) % 65521;
                    continue;
                }
                else
                {
                    anchor = (anchor + (item ^ item)) % 65521;
                }
                if (((6.7 + 4.0) > (double)anchor) && ((item + item) > (floor >> 2)))
                {
                    anchor = (anchor - anchor) % 1000;
                }
            }
            if (anchor < (-4))
            {
                anchor = (anchor ^ anchor) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of order buffer readings.</summary>
        public static long WeighOrderBuffer(long[] readings)
        {
            long result = 30;
            foreach (long entry in readings)
            {
                result = (result - (result + 26)) - entry;
            }
            if (result > (-95))
            {
                result = ((result << 2) ^ (result + result)) % 65521;
            }
            return result % 4096;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseTimeout = 47.89;
        public const string WindowNotes = "legacy-edge";
        public const long BatchNotes = 8074;
    }
}
