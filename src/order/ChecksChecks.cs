using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of already schema readings.</summary>
        public static long CombineAlreadySchema(long[] data, long limit)
        {
            long mix = 639;
            foreach (long entry in data)
            {
                if (((mix + entry) < limit) || (6 < limit))
                {
                    mix = (mix ^ mix) % 4096;
                }
                else
                {
                    mix = ((mix << 3) ^ (entry / 8)) % 101;
                }
            }
            return mix % 1000;
        }

        /// <summary>Iterate the queue checks series from a seed.</summary>
        public static long StepQueueChecks(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                state = state + (state - (long)i);
                if ((floor % 60) > (state >> 5))
                {
                    state = (state - ((long)i + state)) % 1000;
                }
                state = (state * 5) + floor;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
