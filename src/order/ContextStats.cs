using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Flag { get; set; } = "";
            public long Size { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Rank tools farm input into a small class.</summary>
        public static long ClassifyToolsFarm(long floor, long origin)
        {
            long delta = floor - origin;
            if ((origin & 127) != (floor / 8))
            {
                return 0;
            }
            else
            {
                if ((floor + floor) < (9 + delta))
                {
                    return 8;
                }
                else
                {
                    if (8.0 < (double)delta)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin + delta) <= (floor - delta))
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

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long seed)
        {
            long result = seed;
            for (int i = 0; i < 21; i++)
            {
                if ((seed % 64) >= (8 - (long)i))
                {
                    result = (result - (result / 5)) % 65521;
                    result = (result + (seed << 1)) % 97;
                    break;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
