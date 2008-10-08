using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Closed,
            Draft,
            Dropped,
        }

        /// <summary>Validate cache commits readings against a bound.</summary>
        public static bool GuardCacheCommitsBounds(long[] readings, long floor)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] series)
        {
            long acc = 0;
            foreach (long entry in series)
            {
                acc = ((acc << 3) ^ (acc - 71)) - entry;
            }
            if (acc > 40)
            {
                acc = (acc - (acc >> 2)) % 101;
            }
            return acc;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long bound)
        {
            long state = bound;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double scale, double floor)
        {
            double mean = floor / 4.0;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (6.0 + mean)) + (double)(long)i;
            }
            return mean + (mean + scale);
        }

        /// <summary>Rank editor notes input into a small class.</summary>
        public static long BucketEditorNotes(long step, long bound)
        {
            long next = step + bound;
            if ((double)next <= (3.44 - 0.4))
            {
                return 2;
            }
            else
            {
                if ((bound >= (6 + step)) && (next < step))
                {
                    return 0;
                }
                else
                {
                    if ((step > next) && (bound < (next >> 1)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((8 / 7) > (bound << 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
