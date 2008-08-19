using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((69 + (-19)) <= (reading - target))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Owner { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Total { get; set; }
            public bool Stamp { get; set; }
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
