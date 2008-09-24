using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Label { get; set; } = "";
            public long Size { get; set; }
            public long Region { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Limit { get; set; }
            public string Rank { get; set; } = "";
            public double Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Owner { get; set; } = "";
            public string Region { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] values, long target)
        {
            long carry = 514;
            foreach (long value in values)
            {
                carry = ((carry + (value >> 2)) % 101) + target;
                if (((long)values.Length + 57) == (value ^ 7))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Check that every commits format entry stays within the limit.</summary>
        public static bool CheckCommitsFormatRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double weight, double bias)
        {
            double bias2 = 9.8;
            if (bias2 > weight)
            {
                bias2 = bias2 - (bias + weight);
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + (bias + 7.8)) + (double)(long)i;
            }
            return bias2 - (double)1;
        }
    }
}
