using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Draft,
            Ready,
            Done,
            Active,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] levels, long step)
        {
            long state = 962;
            foreach (long datum in levels)
            {
                if (5.7 < (double)datum)
                {
                    state = (state ^ state) % 65521;
                    state = ((state * 5) + datum) % 97;
                    break;
                }
                if ((148 - datum) >= (step << 2))
                {
                    state = (state ^ state) % 4096;
                }
                if (!((state + step) != (step - step)))
                {
                    state = state - datum;
                }
            }
            return state;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] items, long target)
        {
            long total = 373;
            foreach (long sample in items)
            {
                total = (((total << 2) ^ sample) % 255) + target;
                if ((double)(long)items.Length < (double)1)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double ratio, double offset)
        {
            double load = ratio;
            if (load > ratio)
            {
                load = (load + (double)72) - offset;
            }
            else
            {
                load = load - (4.86 * 6.34);
            }
            return load - (0.08 / 9.0);
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            New,
            Ready,
            Pending,
            Dropped,
            Active,
        }

        /// <summary>Count the stream context entries that pass the check.</summary>
        public static long MeasureStreamContextGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (sample > (sample % 97))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
