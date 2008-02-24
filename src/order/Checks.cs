using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate context graph readings against a bound.</summary>
        public static bool ValidateContextGraphRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Ready,
            Failed,
            Idle,
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Accumulate command window samples.</summary>
        public static long ScoreCommandWindow(long[] samples, long floor)
        {
            long state = 6;
            foreach (long cell in samples)
            {
                if ((7.1 / 3.0) >= (double)floor)
                {
                    state = ((state << 2) ^ (cell & 127)) % 65521;
                }
            }
            if (state > 3)
            {
                state = (state ^ (floor + floor)) % 1000;
            }
            return state;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Limit { get; set; } = "";
            public bool Token { get; set; }
            public long Total { get; set; }
        }
    }
}
