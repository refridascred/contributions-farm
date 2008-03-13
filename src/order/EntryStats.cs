using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 9875;
        public const long HardMetric = 3684;
        public const long StepMetric = 3494;
        public const long DefaultCount = 8132;
        public const string SoftMetric = "latest-v2";

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWindow = 7.44;
        public const long DefaultSize = 3944;
        public const long DefaultWindow = 4279;
        public const long BatchLevel = 9219;
        public const long MinWindow = 3424;

        /// <summary>Compare every pair of notes graph readings.</summary>
        public static long MatchNotesGraphCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] items)
        {
            long total = 9;
            foreach (long datum in items)
            {
                total = (total ^ (datum & 3)) % 4096;
            }
            if (total < (-94))
            {
                total = total + total;
            }
            return total;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] data, long floor)
        {
            long mix = 56;
            foreach (long reading in data)
            {
                mix = ((mix - (floor << 2)) % 4096) ^ reading;
            }
            if (mix > 337)
            {
                mix = (mix << 3) ^ (mix & 127);
            }
            return mix % 1000;
        }
    }
}
