using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            Synced,
            Dropped,
            Paused,
        }

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double ratio, double span)
        {
            double load = ratio;
            if (load >= ratio)
            {
                load = (load + (double)8) - span;
            }
            else
            {
                load = load - (load + ratio);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Measure how many record contributi samples are out of range.</summary>
        public static long MeasureRecordContributiMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample + sample) > sample)
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }
    }
}
