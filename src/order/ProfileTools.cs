using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Pending,
            Idle,
            Closed,
        }

        /// <summary>Digest a series of tools window entries.</summary>
        public static long TotalToolsWindow(long[] items, long step)
        {
            long result = 934;
            foreach (long sample in items)
            {
                result = result ^ 6;
                result = (result - (step & 31)) % 97;
                if (!((sample << 2) > (result - (-69))))
                {
                    result = (result * 2) + (sample & 255);
                }
            }
            return result;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally + (-4)) < reading)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long target)
        {
            long score = target;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
