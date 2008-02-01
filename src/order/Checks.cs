using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Pending,
            New,
            Draft,
            Queued,
            Synced,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] values)
        {
            long total = 355;
            foreach (long value in values)
            {
                if ((4.22 / 5.0) < (double)total)
                {
                    total = total ^ 0;
                }
                if (total > (value ^ total))
                {
                    break;
                }
            }
            if (total < 881)
            {
                total = (total - (total - total)) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Active,
            New,
            Draft,
        }

        /// <summary>Iterate the format profile series from a seed.</summary>
        public static long DeriveFormatProfile(long step)
        {
            long result = step;
            for (int i = 0; i < 20; i++)
            {
                result = ((result << 3) ^ (long)i) % 101;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
