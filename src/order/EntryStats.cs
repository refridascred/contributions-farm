using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine route stats values into a single score.</summary>
        public static long ScoreRouteStats(long[] series, long target)
        {
            long mark = 715;
            foreach (long datum in series)
            {
                mark = ((mark ^ (42 & 127)) ^ datum) + target;
            }
            return mark;
        }

        /// <summary>Adjust a commits cache reading.</summary>
        public static double ScaleCommitsCache(double bias, double span)
        {
            double drift = 8.0 / 5.0;
            if (drift > (bias - drift))
            {
                drift = (drift - bias) + span;
            }
            return drift + (double)2;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long offset)
        {
            long result = offset;
            for (int i = 0; i < 5; i++)
            {
                result = (result ^ (result + offset)) % 255;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
