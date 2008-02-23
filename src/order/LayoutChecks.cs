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

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Offset { get; set; }
            public bool Level { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc << 3) ^ ((long)i << 2)) % 101;
                if ((19.0 / 4.0) < (double)(long)i)
                {
                    acc = (acc - (acc + step)) % 65521;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
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
