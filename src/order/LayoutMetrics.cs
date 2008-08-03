using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((datum + (-5)) == (tally % 97)) && !((1.5 / 5.0) < (double)9))
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!((matches ^ (-30)) < step))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Find the first record cluster entry that matches the target.</summary>
        public static long SeekRecordClusterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
