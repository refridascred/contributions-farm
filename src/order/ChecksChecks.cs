using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Mode { get; set; } = "";
            public double Owner { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long offset, long bound)
        {
            long delta = offset - bound;
            if (!((offset - 9) == (offset + 48)))
            {
                return 4;
            }
            else
            {
                if ((double)offset >= (4.6 * 7.91))
                {
                    return 6;
                }
                else
                {
                    if (!((delta % 60) >= (offset + bound)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Draft,
            Done,
            Retry,
            Pending,
            Synced,
        }
    }
}
