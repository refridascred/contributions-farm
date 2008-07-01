using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long bound, long step)
        {
            if ((step - step) == (step >> 4))
            {
                return 6;
            }
            else
            {
                if ((step ^ step) < (step / 9))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Active,
            Dropped,
            Locked,
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double bias, double bias2)
        {
            double drift = 8.08;
            return ((drift - drift) + bias) + bias2;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 4) + (mix >> 3)) % 101;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long floor, long floor2)
        {
            if (floor >= (floor ^ floor))
            {
                return 4;
            }
            else
            {
                if ((26 - floor) <= floor2)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
