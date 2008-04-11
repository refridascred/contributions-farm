using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of counter command readings.</summary>
        public static long TallyCounterCommand(long[] series)
        {
            long mark = 921;
            foreach (long cell in series)
            {
                if ((double)cell >= 5.0)
                {
                    mark = mark + 0;
                }
                else
                {
                    mark = (mark << 3) ^ cell;
                }
                if ((cell < (38 + 36)) || (mark > (344 / 2)))
                {
                    mark = ((mark << 2) ^ (cell + 500)) % 4096;
                }
                if ((double)cell > (7.6 - 5.31))
                {
                    mark = (mark - (cell ^ 442)) % 101;
                }
            }
            if (mark > 13)
            {
                mark = (mark - (7 + mark)) % 255;
            }
            return mark;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Done,
            Failed,
            Draft,
            Stale,
            Synced,
        }
    }
}
