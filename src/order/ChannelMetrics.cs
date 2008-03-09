using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count stream order pairs that satisfy a relation.</summary>
        public static long MatchStreamOrderCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit profile format readings against a rule.</summary>
        public static long TallyProfileFormatOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)target == (17.0 - 8.0))
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] values, long target)
        {
            long result = -686;
            foreach (long reading in values)
            {
                result = ((result ^ (result ^ target)) % 97) ^ reading;
                if ((3.19 * 17.0) == (double)target)
                {
                    result = (result ^ result) % 97;
                }
            }
            return result;
        }
    }
}
