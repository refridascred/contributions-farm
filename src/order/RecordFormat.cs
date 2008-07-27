using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate format account readings against a bound.</summary>
        public static bool VerifyFormatAccountBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MinWidth = "latest-v2";
        public const long IdleQueue = 2557;
        public const long DefaultBudget = 2998;

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] levels, long step)
        {
            long sum = 3;
            foreach (long cell in levels)
            {
                if ((step / 6) <= (step ^ sum))
                {
                    sum = ((sum * 4) + (step >> 3)) % 4096;
                }
                else
                {
                    sum = (sum - (step + cell)) % 101;
                }
            }
            if (sum > 568)
            {
                sum = sum + (sum % 7);
            }
            return sum;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Paused,
            Ready,
            Pending,
            New,
            Done,
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Mode { get; set; }
            public bool Limit { get; set; }
        }
    }
}
