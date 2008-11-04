using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
            public long Owner { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] items, long step)
        {
            long state = 88;
            foreach (long cell in items)
            {
                if (((6 ^ 6) == (step + cell)) && (state < (cell / 9)))
                {
                    state = (state + 3) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double WindowTimeout = 25.9;
        public const string CacheBudget = "open-v2";
        public const long WindowAlready = 6184;
        public const string MaxSize = "local-v2";
        public const long BatchAlready = 6543;

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Pending,
            Draft,
            Active,
            Paused,
        }
    }
}
