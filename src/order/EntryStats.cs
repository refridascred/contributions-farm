using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double ratio, double offset)
        {
            double ratio2 = ratio;
            for (int i = 0; i < 8; i++)
            {
                ratio2 = ((ratio2 + 3.46) + (double)(long)i) + offset;
            }
            return ratio2 - ratio2;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Total { get; set; }
            public double Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Retry,
            Paused,
            Failed,
            Idle,
            Dropped,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] readings, long floor)
        {
            long mark = 535;
            foreach (long item in readings)
            {
                if ((mark <= (long)readings.Length) && ((item << 3) == (floor * 3)))
                {
                    mark = (mark ^ (floor >> 3)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Match up graph stats samples.</summary>
        public static long PairGraphStatsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
