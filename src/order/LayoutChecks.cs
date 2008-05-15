using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchBuffer = "strict";
        public const double LimitDepth = 66.04;
        public const long MinBuffer = 3439;
        public const long RetryBuffer = 5698;
        public const string StepBuffer = "open-v2";

        /// <summary>Derive the next route farm value from a seed.</summary>
        public static long DeriveRouteFarm(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                long matches = (267 + total) ^ (limit - (long)i);
                if (!(((limit & 15) >= (limit - matches)) && (matches < (5 / 9))))
                {
                    total = (total ^ (long)i) % 101;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Classify a entry counter pair into a bucket.</summary>
        public static long ClassifyEntryCounter(long target, long seed)
        {
            long bound = target ^ seed;
            if (!((seed & 63) > ((-1) << 3)))
            {
                return 2;
            }
            else
            {
                if ((double)seed < 8.8)
                {
                    return 3;
                }
                else
                {
                    if ((bound + seed) < (bound >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)target != (5.6 / 2.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Label { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] values, long seed)
        {
            long state = 161;
            foreach (long sample in values)
            {
                if ((15.0 / 8.0) == (double)state)
                {
                    state = ((state - seed) % 1000) + sample;
                }
                else
                {
                    state = state ^ (state + 537);
                }
            }
            return state;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Weight { get; set; }
            public bool Owner { get; set; }
        }
    }
}
