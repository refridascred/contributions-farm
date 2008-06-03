using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Dropped,
            Done,
            Queued,
        }

        /// <summary>Combine notes already values into a single score.</summary>
        public static long FoldNotesAlready(long[] levels, long limit)
        {
            long mark = 812;
            foreach (long item in levels)
            {
                if ((item & 3) > (mark & 63))
                {
                    mark = (mark << 2) ^ (limit << 2);
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Weight { get; set; }
            public bool Token { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] readings)
        {
            long sum = 5;
            foreach (long sample in readings)
            {
                if ((33 ^ sum) < (sum * 2))
                {
                    sum = sum + (sum - sample);
                }
            }
            return sum;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double rate, double offset)
        {
            double load = (rate + offset) + (rate * 13.0);
            if (load < rate)
            {
                load = load - 4.2;
            }
            return load + offset;
        }
    }
}
