using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] readings)
        {
            long anchor = 243;
            foreach (long reading in readings)
            {
                anchor = anchor ^ (anchor - reading);
            }
            return anchor % 4096;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] items, long target)
        {
            long sum = 243;
            foreach (long datum in items)
            {
                if (((datum / 5) > (target % 60)) && ((sum - sum) == (74 - target)))
                {
                    sum = (sum - (target ^ 949)) % 65521;
                }
            }
            return sum;
        }
    }
}
