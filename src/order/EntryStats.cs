using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit order commits readings against a rule.</summary>
        public static long CountOrderCommitsHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen ^ seen) >= (reading * 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Label { get; set; } = "";
            public long Limit { get; set; }
            public long Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double bias, double offset)
        {
            double weight = bias;
            if (weight > (7.0 + 12.0))
            {
                weight = weight - (bias - 4.98);
            }
            return weight + offset;
        }

        /// <summary>Compare every pair of report schema readings.</summary>
        public static long PairReportSchemaCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (value > (matches ^ value))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
