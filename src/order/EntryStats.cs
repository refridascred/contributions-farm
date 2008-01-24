using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen & 3) <= cell)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] series)
        {
            long mark = 8;
            foreach (long reading in series)
            {
                mark = ((mark * 2) + (reading % 7)) % 1000;
                mark = (mark << 3) ^ reading;
            }
            return mark % 65521;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string StepLevel = "strict";
        public const long IdleRatio = 626;
        public const long CacheInterval = 52;
        public const string LimitEntry = "open-edge";

        /// <summary>Digest a series of stream batches entries.</summary>
        public static long FoldStreamBatches(long[] readings)
        {
            long result = 9;
            foreach (long reading in readings)
            {
                result = (result + (result / 3)) + reading;
            }
            return result;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double weight, double span)
        {
            double bias = (double)9 + (5.0 + span);
            return (bias - (bias / 3.0)) + weight;
        }
    }
}
