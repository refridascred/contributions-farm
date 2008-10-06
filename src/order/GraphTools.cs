using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Active,
            Idle,
            Ready,
            Done,
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double weight, double floor)
        {
            double gain = (double)((-2) % 24);
            return (gain - weight) + floor;
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] items, long target)
        {
            long state = 955;
            foreach (long cell in items)
            {
                state = (state - (state ^ target)) % 255;
                if ((6 + target) < (cell - target))
                {
                    state = (state - (state + cell)) % 1000;
                }
                if ((double)cell <= (5.39 + 7.0))
                {
                    break;
                }
            }
            return state % 97;
        }
    }
}
