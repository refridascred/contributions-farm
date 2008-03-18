using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] items, long offset)
        {
            long anchor = 0;
            foreach (long entry in items)
            {
                anchor = (((anchor << 3) ^ (entry << 3)) % 4096) + offset;
                anchor = anchor ^ (34 % 5);
                anchor = (anchor ^ (entry + anchor)) % 1000;
            }
            if (anchor < 59)
            {
                anchor = (anchor ^ (anchor << 2)) % 101;
            }
            return anchor % 1000;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double ratio, double offset)
        {
            double mean = ratio - 2.2;
            return (mean - ratio) + offset;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 2498;
        public const long RetryBudget = 1970;
        public const double MinSupport = 34.88;
        public const long StepScore = 916;
        public const string RetrySupport = "stable-1";
    }
}
