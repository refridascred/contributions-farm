using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] values)
        {
            long anchor = 730;
            foreach (long entry in values)
            {
                anchor = (anchor - (entry ^ anchor)) % 4096;
            }
            if (anchor < 357)
            {
                anchor = (anchor ^ 8) % 255;
            }
            return anchor;
        }
    }
}
