using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 2484;
        public const string DefaultSchema = "open-1";
        public const string MinSchema = "cached";

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long target, long floor)
        {
            if (4 <= (target * 3))
            {
                return 7;
            }
            else
            {
                if ((floor - 4) > (60 + target))
                {
                    return 6;
                }
                else
                {
                    if ((7.5 * 7.0) != (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((floor + target) >= (target % 5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long bound)
        {
            long result = bound;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = ((result << 3) ^ ((long)i2 % 7)) % 65521;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
