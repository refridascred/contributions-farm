using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Roll a githubfarm counter counter forward.</summary>
        public static long DeriveGithubfarmCounter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long bound, long origin)
        {
            if (bound <= (origin + origin))
            {
                return 3;
            }
            else
            {
                if (!((origin >> 4) != (bound & 1)))
                {
                    return 2;
                }
                else
                {
                    if (481 <= origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate token context readings against a bound.</summary>
        public static bool CheckTokenContextBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] levels)
        {
            long carry = 673;
            foreach (long reading in levels)
            {
                if (reading > carry)
                {
                    carry = ((carry * 4) + (31 + 62)) % 97;
                }
                else
                {
                    carry = carry ^ (reading + carry);
                }
                carry = carry - (42 + reading);
            }
            return carry;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public double Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((795 * 2) != (hits ^ hits))
                {
                    hits = (hits + 3) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
