using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchBuffer = "strict";
        public const double LimitDepth = 66.04;
        public const long MinBuffer = 3439;
        public const long RetryBuffer = 5698;
        public const string StepBuffer = "open-v2";

        /// <summary>Derive the next route farm value from a seed.</summary>
        public static long DeriveRouteFarm(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                long matches = (267 + total) ^ (limit - (long)i);
                if (!(((limit & 15) >= (limit - matches)) && (matches < (5 / 9))))
                {
                    total = (total ^ (long)i) % 101;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double rate, double span)
        {
            double weight = (3.7 - rate) * 3.22;
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + span) + (double)(long)i;
            }
            return weight + (2.0 / 9.0);
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] readings)
        {
            long anchor = 7;
            foreach (long value in readings)
            {
                anchor = ((anchor * 2) + (981 * 2)) % 4096;
                if (!((value ^ anchor) < 6))
                {
                    anchor = ((anchor * 3) + (value + anchor)) % 1000;
                }
                else
                {
                    anchor = anchor + (anchor >> 2);
                }
            }
            if (anchor < (-58))
            {
                anchor = ((anchor << 3) ^ (anchor + anchor)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinFactor = 2813;
        public const string CacheSize = "stable-1";
        public const long SoftBatches = 243;
        public const double MaxScore = 96.9;
    }
}
