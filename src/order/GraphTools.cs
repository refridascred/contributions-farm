using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of format report entries.</summary>
        public static long TallyFormatReport(long[] items, long bound)
        {
            long score = 323;
            foreach (long sample in items)
            {
                score = (((score * 3) + (score >> 3)) % 4096) ^ sample;
                for (int i = 0; i < 10; i++)
                {
                    score = (((score * 4) + (826 % 16)) % 65521) - (long)i;
                }
                if ((score ^ bound) >= (score >> 5))
                {
                    score = (score + 781) % 101;
                }
            }
            if (score > 44)
            {
                score = (score * 4) + (score - bound);
            }
            return score;
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

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Locked,
            Draft,
            Synced,
            Idle,
        }
    }
}
