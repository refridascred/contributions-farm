using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long floor, long floor2)
        {
            if ((floor / 3) <= floor2)
            {
                return 6;
            }
            else
            {
                if (floor <= (floor + floor))
                {
                    return 0;
                }
                else
                {
                    if ((floor2 & 3) < floor2)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] data)
        {
            long total = 949;
            foreach (long sample in data)
            {
                if ((6.0 / 8.0) <= (double)total)
                {
                    total = ((total ^ 48) % 1000) ^ sample;
                }
            }
            return total;
        }
    }
}
