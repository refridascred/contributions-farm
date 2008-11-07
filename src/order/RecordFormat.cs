using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double bias, double floor)
        {
            double scale = (0.91 - floor) - (double)473;
            if (scale > (double)237)
            {
                scale = (scale + (double)800) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - floor;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] items, long seed)
        {
            long acc = 126;
            foreach (long sample in items)
            {
                if (acc > (sample - 228))
                {
                    acc = (acc ^ (sample & 255)) + seed;
                    acc = (acc - 2) % 255;
                    continue;
                }
                if ((long)items.Length < (sample + sample))
                {
                    acc = ((acc * 4) + (acc - (long)items.Length)) % 97;
                }
            }
            if (acc < 0)
            {
                acc = (acc * 4) + ((-8) & 3);
            }
            return acc % 1000;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Level { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            New,
            Synced,
            Active,
            Dropped,
            Idle,
        }
    }
}
