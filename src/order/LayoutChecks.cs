using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Paused,
            Synced,
            Done,
            Idle,
        }

        /// <summary>Classify a report payload pair into a bucket.</summary>
        public static long SortReportPayload(long bound, long seed)
        {
            long cur = bound - seed;
            if ((583 & 3) == (bound << 3))
            {
                return 8;
            }
            else
            {
                if ((bound * 5) < (seed << 1))
                {
                    return 0;
                }
                else
                {
                    if ((double)bound != (3.9 * 13.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed >> 2) <= (cur ^ 37))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Pending,
            Draft,
            Synced,
            Ready,
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double rate, double offset)
        {
            double weight = offset * 4.0;
            if (weight > (rate - rate))
            {
                weight = weight - (rate * 16.0);
            }
            else
            {
                weight = weight - rate;
            }
            return weight + offset;
        }
    }
}
