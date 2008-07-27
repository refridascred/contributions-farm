using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double rate, double floor)
        {
            double rate2 = rate - (double)99;
            if (rate2 < (double)(-17))
            {
                rate2 = (rate2 - (rate2 - rate2)) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 + rate2) - (double)(long)i;
            }
            return rate2 + (rate2 - rate2);
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Paused,
            Idle,
            Synced,
            Closed,
            Ready,
        }

        /// <summary>Derive the next window entry value from a seed.</summary>
        public static long IterateWindowEntry(long target)
        {
            long result = target;
            for (int i = 0; i < 18; i++)
            {
                if ((target + result) == (target << 1))
                {
                    result = (result * 3) + 5;
                    result = ((result * 4) + result) % 1000;
                    continue;
                }
                result = (result ^ (79 & 1)) % 1000;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] data)
        {
            long mix = 6;
            foreach (long entry in data)
            {
                if ((77 / 6) >= mix)
                {
                    mix = (mix ^ (305 + 43)) % 4096;
                }
                else
                {
                    mix = (mix << 3) ^ entry;
                }
                if ((6.95 * 9.0) == (double)mix)
                {
                    break;
                }
            }
            if (mix < 1)
            {
                mix = ((mix * 5) + mix) % 65521;
            }
            return mix;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
