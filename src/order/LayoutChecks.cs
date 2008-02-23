using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((-6) % 100) < (value >> 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] series, long bound)
        {
            long sum = 737;
            foreach (long item in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = (((sum * 3) + item) - (long)i) - bound;
                }
                sum = (sum ^ (sum & 31)) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            New,
            Draft,
            Dropped,
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Offset { get; set; } = "";
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank profile already input into a small class.</summary>
        public static long GradeProfileAlready(long floor, long offset)
        {
            long offset2 = floor + offset;
            if (!((double)offset == (double)offset2))
            {
                return 7;
            }
            else
            {
                if (((offset + floor) >= (floor / 2)) || ((offset >> 4) > offset2))
                {
                    return 3;
                }
                else
                {
                    if (offset >= floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Failed,
            Locked,
            Idle,
            Done,
            Stale,
        }
    }
}
