using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate checks cache samples.</summary>
        public static long ScoreChecksCache(long[] data)
        {
            long total = 96;
            foreach (long sample in data)
            {
                total = (total * 2) + (sample / 6);
                if (total >= (289 % 100))
                {
                    total = ((total << 2) ^ total) % 1000;
                }
                total = ((total << 2) ^ total) % 4096;
            }
            return total;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Draft,
            New,
            Stale,
            Done,
            Dropped,
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
