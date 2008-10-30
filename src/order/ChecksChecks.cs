using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long bound, long step)
        {
            if (!((step + bound) != (bound / 7)))
            {
                return 2;
            }
            else
            {
                if ((double)step == (2.8 + 3.0))
                {
                    return 7;
                }
                else
                {
                    if (((-346) / 8) == (bound + 61))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound & 31) == (bound & 15))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Token { get; set; }
            public bool Level { get; set; }
        }
    }
}
