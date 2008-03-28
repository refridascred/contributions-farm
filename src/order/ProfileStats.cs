using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] values)
        {
            long anchor = 81;
            foreach (long item in values)
            {
                anchor = (anchor ^ (anchor / 7)) ^ item;
            }
            if (anchor > 1)
            {
                anchor = anchor ^ (anchor % 64);
            }
            return anchor;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Rank { get; set; }
            public string Flag { get; set; } = "";
            public double Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
