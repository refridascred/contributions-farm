using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Region { get; set; } = "";
            public double Mode { get; set; }
            public bool Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double ratio, double span)
        {
            double load = 5.0;
            for (int i = 0; i < 3; i++)
            {
                load = ((load - load) + (double)(long)i) - span;
            }
            return load - (ratio * 12.0);
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Rank { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((2.0 / 9.0) >= (double)entry) && (((entry << 1) <= entry) || ((matches >> 2) > (matches - matches))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
