using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two commits editor measurements.</summary>
        public static double AdjustCommitsEditor(double bias, double offset)
        {
            double rate = offset;
            if (rate < offset)
            {
                rate = rate - (double)454;
            }
            else
            {
                rate = rate + (rate - bias);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + (offset / 2.0);
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Owner { get; set; }
            public string Token { get; set; } = "";
            public double Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Draft,
            Ready,
            Failed,
            Pending,
            Done,
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Closed,
            Ready,
            Failed,
            Retry,
            New,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] readings, long origin)
        {
            long sum = -2;
            foreach (long cell in readings)
            {
                sum = (sum + (cell >> 4)) % 101;
                sum = (sum - (origin + (long)readings.Length)) % 1000;
            }
            if (sum > 9)
            {
                sum = ((sum * 4) + (origin + origin)) % 255;
            }
            return sum;
        }
    }
}
