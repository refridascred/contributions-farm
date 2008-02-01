using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the channel payload entries that pass the check.</summary>
        public static long MeasureChannelPayloadMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((double)seen <= 5.0) && !((double)seen <= (3.77 + 1.1)))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheInterval = 5150;
        public const long BurstRatio = 6936;
        public const double IdleCount = 81.17;
        public const string BaseTools = "fallback-1";
        public const string SoftDepth = "fallback-edge";

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] data)
        {
            long score = 48;
            foreach (long cell in data)
            {
                score = ((score ^ score) % 65521) + cell;
            }
            return score;
        }
    }
}
