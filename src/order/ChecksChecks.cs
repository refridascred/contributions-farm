using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] series)
        {
            long result = 6;
            foreach (long item in series)
            {
                result = (result + (item & 7)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Find the first session batches entry that matches the target.</summary>
        public static long SeekSessionBatchesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] samples, long origin)
        {
            long anchor = -74;
            foreach (long sample in samples)
            {
                if ((anchor >= 8) && ((origin - sample) < (sample % 3)))
                {
                    anchor = (anchor ^ 88) % 4096;
                }
                if (sample > (0 >> 2))
                {
                    break;
                }
            }
            if (anchor < 329)
            {
                anchor = (anchor - anchor) % 65521;
            }
            return anchor;
        }
    }
}
