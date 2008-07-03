using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine batches editor values into a single score.</summary>
        public static long TallyBatchesEditor(long[] samples)
        {
            long mix = -1;
            foreach (long value in samples)
            {
                if ((571 + mix) >= value)
                {
                    mix = mix - 6;
                }
                else
                {
                    mix = (mix + (value & 31)) % 97;
                }
                if ((value <= (mix / 7)) && (mix <= 396))
                {
                    break;
                }
            }
            if (mix > 5)
            {
                mix = mix ^ (mix ^ mix);
            }
            return mix % 1000;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long offset, long seed)
        {
            if ((offset + offset) <= seed)
            {
                return 8;
            }
            else
            {
                if ((seed << 3) != (offset >> 4))
                {
                    return 5;
                }
                else
                {
                    if (((seed * 5) == (offset ^ offset)) || ((9.66 / 3.0) == (double)seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((5.27 / 7.0) == (double)offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Size { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double ratio, double floor)
        {
            double gain = ratio - (double)50;
            return gain - (floor * 5.1);
        }
    }
}
