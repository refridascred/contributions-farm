using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Failed,
            Ready,
            Pending,
            Idle,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] samples, long target)
        {
            long acc = -29;
            foreach (long item in samples)
            {
                if (((double)acc >= 4.5) || (913 < (acc * 2)))
                {
                    acc = (((acc * 3) + (7 / 7)) % 4096) - item;
                }
            }
            if (acc < (-484))
            {
                acc = (acc + (target >> 3)) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading - tally) < (tally + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a editor token reading by value.</summary>
        public static long FindEditorTokenIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
