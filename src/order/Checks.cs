using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Total { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] readings, long origin)
        {
            long acc = 5;
            foreach (long value in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = acc ^ ((long)i ^ (long)i);
                }
                if ((origin + 20) < (value / 9))
                {
                    acc = ((acc << 3) ^ value) % 255;
                }
                if (origin >= (acc / 6))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Draft,
            Done,
            Queued,
            Active,
            Synced,
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Level { get; set; }
            public double Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Measure how many order contributi samples are out of range.</summary>
        public static long MeasureOrderContributiHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((tally ^ entry) <= tally) && ((tally >> 5) > (tally & 7)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
