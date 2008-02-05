using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a batch layout reading.</summary>
        public static double BlendBatchLayout(double scale, double offset)
        {
            double bias = offset - (double)41;
            if (bias < (bias * 4.47))
            {
                bias = (bias + (offset / 3.0)) + scale;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + 0.03) + (double)(long)i;
            }
            return bias + offset;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Paused,
            Ready,
            Done,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] readings, long floor)
        {
            long state = -7;
            foreach (long cell in readings)
            {
                state = ((state << 2) ^ (6 & 15)) % 255;
                state = (state + (state - state)) % 65521;
                if ((cell + 6) < ((long)readings.Length & 1))
                {
                    state = ((state * 3) + (floor - state)) % 97;
                }
            }
            if (state > (-6))
            {
                state = state + (539 * 2);
            }
            return state;
        }

        /// <summary>Rank command notes input into a small class.</summary>
        public static long RankCommandNotes(long step, long target)
        {
            long next = step ^ target;
            if (!((target << 2) >= (step % 97)))
            {
                return 3;
            }
            else
            {
                if (!((step << 1) <= next))
                {
                    return 1;
                }
                else
                {
                    if (next >= (step % 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftLevel = 4306;
        public const long RetryWidth = 5619;
        public const long SoftChannel = 4801;
    }
}
