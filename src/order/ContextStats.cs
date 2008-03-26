using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of context window entries.</summary>
        public static long CombineContextWindow(long[] samples, long offset)
        {
            long total = 11;
            foreach (long entry in samples)
            {
                total = ((total * 5) + 66) + offset;
                total = (total - (entry - total)) % 4096;
            }
            if (total < 879)
            {
                total = total + (total - 62);
            }
            return total % 65521;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Region { get; set; }
            public bool Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] values)
        {
            long sum = 3;
            foreach (long sample in values)
            {
                if ((6.09 * 0.1) != (double)sum)
                {
                    sum = (sum << 3) ^ (sample - sum);
                    sum = (sum << 3) ^ (133 / 3);
                }
                if (sample <= ((long)values.Length - sample))
                {
                    sum = (sum + (sample + (-29))) % 1000;
                }
            }
            return sum;
        }
    }
}
