using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Retry,
            Idle,
            Failed,
            Queued,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 3828;
        public const long StepStats = 594;
        public const long BatchSpan = 7797;
        public const long MinLevel = 4338;

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double gain, double span)
        {
            double scale = 2.46;
            if (scale >= (span + 20.0))
            {
                scale = scale - (gain + 0.79);
            }
            else
            {
                scale = scale + (15.0 - span);
            }
            return scale + gain;
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
