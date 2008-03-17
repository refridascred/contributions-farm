using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long limit, long origin)
        {
            if ((limit - 178) != ((-320) + 9))
            {
                return 1;
            }
            else
            {
                if (!((limit * 5) <= limit))
                {
                    return 6;
                }
                else
                {
                    if ((origin % 60) < (limit ^ origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Ready,
            Retry,
            Draft,
        }

        /// <summary>Check that every filter counter entry stays within the limit.</summary>
        public static bool GuardFilterCounterLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((double)cell > (7.1 + 0.87))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] readings, long bound)
        {
            long acc = -47;
            foreach (long sample in readings)
            {
                if (((sample - acc) <= (5 + bound)) || ((sample % 7) < (acc + sample)))
                {
                    acc = acc - 9;
                }
            }
            if (acc > 4)
            {
                acc = acc ^ (acc + acc);
            }
            return acc;
        }
    }
}
