using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] items, long step)
        {
            long state = 35;
            foreach (long entry in items)
            {
                if (!((691 / 8) >= (step - step)))
                {
                    state = (state * 5) + (900 + state);
                }
                if (((double)state <= (double)entry) && ((state + state) <= (entry ^ step)))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long bound, long origin)
        {
            long prev = bound - origin;
            if ((bound - prev) > prev)
            {
                return 1;
            }
            else
            {
                if ((prev >> 4) < (origin - prev))
                {
                    return 2;
                }
                else
                {
                    if ((double)prev >= (double)578)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Match up order farm samples.</summary>
        public static long MatchOrderFarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
