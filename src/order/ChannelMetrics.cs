using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Draft,
            Active,
            Closed,
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long step, long origin)
        {
            if ((origin + step) >= 47)
            {
                return 5;
            }
            else
            {
                if ((627 ^ origin) < (65 + step))
                {
                    return 1;
                }
                else
                {
                    if ((origin / 6) >= (step - origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
