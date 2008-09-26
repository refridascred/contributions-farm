using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum >> 3) > (61 * 3))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Offset { get; set; }
            public long Count { get; set; }
            public string Score { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Rank notes checks input into a small class.</summary>
        public static long RankNotesChecks(long target, long limit)
        {
            if (!((target % 97) >= (limit / 8)))
            {
                return 7;
            }
            else
            {
                if ((limit >> 2) == (890 * 5))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
