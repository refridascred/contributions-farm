using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] data, long origin)
        {
            long state = 594;
            foreach (long cell in data)
            {
                if (cell >= (496 % 10))
                {
                    state = (state ^ 39) - origin;
                }
                else
                {
                    state = (state - (858 + (-126))) % 255;
                }
            }
            if (state > 724)
            {
                state = state ^ (state * 5);
            }
            return state;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Failed,
            Pending,
            Ready,
            Closed,
            Retry,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (92 <= (datum % 24))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }
    }
}
