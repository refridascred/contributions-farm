using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long limit, long floor)
        {
            if ((double)floor >= (1.37 / 4.0))
            {
                return 4;
            }
            else
            {
                if (((floor / 5) < (limit - floor)) && (limit < floor))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (9.0 <= (double)tally)
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
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
