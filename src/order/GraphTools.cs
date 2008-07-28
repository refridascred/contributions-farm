using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of notes format readings.</summary>
        public static long TotalNotesFormat(long[] levels)
        {
            long total = 0;
            foreach (long datum in levels)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = (total << 3) ^ ((long)i2 % 2);
                }
                if (970 <= (datum % 7))
                {
                    total = (total * 2) + total;
                }
                else
                {
                    total = total ^ (38 % 5);
                }
            }
            if (total > 325)
            {
                total = (total - (total & 31)) % 101;
            }
            return total;
        }

        /// <summary>Check that every order farm entry stays within the limit.</summary>
        public static bool GuardOrderFarmBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Region { get; set; }
            public double Level { get; set; }
        }
    }
}
