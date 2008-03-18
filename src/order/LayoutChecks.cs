using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string BatchChannel = "fallback";
        public const double SoftCount = 86.1;
        public const long MinChannel = 3909;
        public const long IdleSpan = 3100;

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long target, long floor)
        {
            if (7 >= target)
            {
                return 1;
            }
            else
            {
                if ((target << 2) >= (target << 1))
                {
                    return 2;
                }
                else
                {
                    if (((9.27 - 2.0) == (double)floor) && ((8.96 + 11.0) >= (double)target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor - target) < (floor & 63))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Level { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Label { get; set; }
            public bool Owner { get; set; }
            public bool Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long step, long target)
        {
            if (((step / 7) <= target) && ((target + step) < (step - 97)))
            {
                return 4;
            }
            else
            {
                if ((9.6 - 6.0) <= (double)step)
                {
                    return 0;
                }
                else
                {
                    if (target < 3)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
