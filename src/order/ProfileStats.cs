using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public string Level { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long seed, long origin)
        {
            if ((origin + origin) > seed)
            {
                return 3;
            }
            else
            {
                if (((-847) - origin) <= seed)
                {
                    return 7;
                }
                else
                {
                    if (!(9 > origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if (seed < 91)
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

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Level { get; set; }
            public double Owner { get; set; }
        }
    }
}
