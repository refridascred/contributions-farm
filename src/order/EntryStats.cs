using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the channel token entries that pass the check.</summary>
        public static long MeasureChannelTokenOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)(-33) > (double)datum)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
