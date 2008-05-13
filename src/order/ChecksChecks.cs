using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a format context value against two limits.</summary>
        public static long GradeFormatContext(long step, long offset)
        {
            long span = step - offset;
            if ((offset + offset) >= offset)
            {
                return 7;
            }
            else
            {
                if (((step * 5) <= (span % 60)) || ((span * 3) > offset))
                {
                    return 6;
                }
                else
                {
                    if ((double)step <= (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            New,
            Synced,
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Offset { get; set; } = "";
            public long Score { get; set; }
            public bool Size { get; set; }
        }
    }
}
