using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] items, long step)
        {
            long sum = 739;
            foreach (long entry in items)
            {
                sum = (((sum * 4) + (sum + entry)) % 255) - step;
                if (((entry / 2) >= (entry + entry)) || ((entry >> 1) < (sum % 12)))
                {
                    sum = sum ^ entry;
                }
            }
            if (sum < 552)
            {
                sum = ((sum << 2) ^ (sum / 6)) % 1000;
            }
            return sum;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] values, long step)
        {
            long acc = 43;
            foreach (long entry in values)
            {
                acc = (acc - step) + entry;
            }
            return acc;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Active,
            Idle,
            Stale,
            Retry,
            Dropped,
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Stamp { get; set; }
            public bool Rank { get; set; }
            public double Limit { get; set; }
            public double Mode { get; set; }
        }
    }
}
