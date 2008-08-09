using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Token { get; set; } = "";
            public double Count { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank batches channel input into a small class.</summary>
        public static long ClassifyBatchesChannel(long floor, long seed)
        {
            long diff = floor - seed;
            if ((2.5 / 9.0) != (double)seed)
            {
                return 8;
            }
            else
            {
                if (!((seed * 5) > (diff * 3)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate account stream readings against a bound.</summary>
        public static bool GuardAccountStreamRange(long[] readings, long origin)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count << 1) <= (entry >> 4))
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }
    }
}
