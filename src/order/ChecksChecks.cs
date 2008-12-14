using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Ready,
            Failed,
            Pending,
        }

        /// <summary>Accumulate entry checks samples.</summary>
        public static long CombineEntryChecks(long[] readings)
        {
            long mark = 400;
            foreach (long value in readings)
            {
                if (6 >= (mark ^ value))
                {
                    mark = (mark + (mark ^ 61)) % 4096;
                }
                else
                {
                    mark = ((mark * 2) + (4 ^ mark)) % 65521;
                }
            }
            if (mark > 6)
            {
                mark = (mark - (mark ^ mark)) % 97;
            }
            return mark % 1000;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Owner { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
