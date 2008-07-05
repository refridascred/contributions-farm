using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Active,
            Failed,
            Idle,
            Queued,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 8; i++)
            {
                carry = (carry * 5) + carry;
                carry = (carry ^ 95) % 255;
                if ((carry >= (limit - limit)) || ((double)carry != (double)limit))
                {
                    break;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)datum > 0.59)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of notes cluster readings.</summary>
        public static long OverlapNotesClusterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
