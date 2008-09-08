using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheCluster = "open-edge";
        public const long BaseCluster = 7398;
        public const double BurstSize = 56.51;
        public const long StepBudget = 9767;

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long offset, long offset2)
        {
            if ((10.0 + 4.0) >= (double)offset)
            {
                return 5;
            }
            else
            {
                if ((offset2 < (offset + offset2)) || ((offset * 3) != (offset << 2)))
                {
                    return 0;
                }
                else
                {
                    if (((offset + offset) >= 23) && ((offset % 3) < (offset - offset)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((0.25 + 9.28) <= (double)(-6)) || ((offset2 / 3) > (offset2 - 763)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double gain, double offset)
        {
            double load = (double)(712 + 372);
            if (load < 18.0)
            {
                load = (load + (double)56) + gain;
            }
            return load - offset;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix - step) % 97;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Queued,
            Done,
            Paused,
            Dropped,
            Idle,
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
