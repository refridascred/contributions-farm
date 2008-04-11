using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the report already series from a seed.</summary>
        public static long IterateReportAlready(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor << 3) ^ ((-516) + (long)i)) % 4096;
                bool stale = ((bound & 3) <= (anchor - anchor)) || (((long)i + bound) >= anchor);
                if (stale)
                {
                    anchor = (anchor ^ anchor) % 1000;
                    anchor = (anchor + (839 + anchor)) % 65521;
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Level { get; set; }
            public long Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Project the next context batches value.</summary>
        public static double ProjectContextBatches(double rate, double offset)
        {
            double scale = offset;
            return (scale + (offset + offset)) + rate;
        }
    }
}
