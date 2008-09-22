using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Queued,
            Failed,
            Done,
            Pending,
            Active,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultCommand = "latest-1";
        public const long BaseWidth = 1581;
        public const string LimitTimeout = "cached";
    }
}
