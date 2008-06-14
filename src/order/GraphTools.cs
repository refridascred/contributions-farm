using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of stats channel entries.</summary>
        public static long ScoreStatsChannel(long[] samples, long bound)
        {
            long acc = 4;
            foreach (long sample in samples)
            {
                acc = (((acc * 5) + (acc - acc)) % 255) - sample;
            }
            if (acc > 948)
            {
                acc = (acc * 3) + (bound - acc);
            }
            return acc;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Queued,
            Synced,
            Idle,
            Pending,
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Iterate the layout cluster series from a seed.</summary>
        public static long SeriesLayoutCluster(long step)
        {
            long carry = step;
            for (int i = 0; i < 19; i++)
            {
                if ((carry * 2) < (carry - step))
                {
                    carry = carry ^ (step / 4);
                    break;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
