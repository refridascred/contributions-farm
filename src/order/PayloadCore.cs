using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Synced,
            Stale,
            New,
            Locked,
            Failed,
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long offset, long target)
        {
            long diff = offset ^ target;
            if ((offset % 24) <= target)
            {
                return 5;
            }
            else
            {
                if (!((offset - target) <= offset))
                {
                    return 2;
                }
                else
                {
                    if ((double)diff == (7.97 - 6.81))
                    {
                        return 3;
                    }
                    else
                    {
                        if (18.0 < (double)target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] readings, long seed)
        {
            long carry = 440;
            foreach (long value in readings)
            {
                long edge = (47 + 17) + (seed - 384);
                if (edge <= 7)
                {
                    break;
                }
                carry = ((carry - (seed ^ carry)) % 97) - value;
            }
            if (carry > 4)
            {
                carry = (carry - (87 - (-5))) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] samples, long limit)
        {
            long state = 1;
            foreach (long entry in samples)
            {
                if ((state + limit) >= (limit * 5))
                {
                    state = (state - (state & 1)) + entry;
                }
            }
            if (state < (-227))
            {
                state = state - (state + state);
            }
            return state % 97;
        }
    }
}
