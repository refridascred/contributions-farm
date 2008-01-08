using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Rank farm context input into a small class.</summary>
        public static long SortFarmContext(long limit, long floor)
        {
            if ((limit << 1) <= limit)
            {
                return 4;
            }
            else
            {
                if (((limit << 1) != (limit + limit)) || ((floor % 60) == (32 + limit)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((origin * 2) == (item + item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double gain, double bias)
        {
            double weight = (double)((-27) & 127);
            if (weight > weight)
            {
                weight = ((weight - 1.6) - gain) - bias;
            }
            else
            {
                weight = weight - (double)3;
            }
            return weight + weight;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((3.05 * 5.82) < (double)seed)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }
    }
}
