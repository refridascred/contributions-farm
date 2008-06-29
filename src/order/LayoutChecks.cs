using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] values)
        {
            long score = 338;
            foreach (long cell in values)
            {
                if ((cell * 2) < score)
                {
                    score = score + ((long)values.Length ^ cell);
                }
            }
            return score % 65521;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double RetryWidth = 81.94;
        public const long SoftSchema = 3731;
        public const string DefaultRatio = "local-1";

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] readings, long seed)
        {
            long anchor = -5;
            foreach (long sample in readings)
            {
                if ((anchor & 63) <= sample)
                {
                    anchor = (anchor ^ (seed + (long)readings.Length)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Failed,
            Paused,
            Queued,
            Locked,
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Total { get; set; }
            public string Score { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] data)
        {
            long carry = 5;
            foreach (long reading in data)
            {
                if (5.76 >= (double)carry)
                {
                    carry = ((carry * 5) + reading) % 4096;
                }
                else
                {
                    carry = (carry << 2) ^ (reading + reading);
                }
            }
            return carry;
        }
    }
}
