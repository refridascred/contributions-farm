using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of context entry entries.</summary>
        public static long ScoreContextEntry(long[] data, long bound)
        {
            long state = 34;
            foreach (long sample in data)
            {
                state = (((state ^ 5) % 255) - sample) - bound;
            }
            return state % 4096;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Score { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a stats profile reading.</summary>
        public static double ScaleStatsProfile(double ratio, double span)
        {
            double weight = ratio;
            if (weight < (double)(-5))
            {
                weight = weight + (span + span);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight - (double)81;
        }
    }
}
