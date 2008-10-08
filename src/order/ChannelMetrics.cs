using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long step, long step2)
        {
            if (((step2 >> 5) < step) || (step2 < (step2 % 3)))
            {
                return 0;
            }
            else
            {
                if ((8.0 / 8.0) == (double)step)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
