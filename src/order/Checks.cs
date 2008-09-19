using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up metric record samples.</summary>
        public static long CompareMetricRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count * 5) > (item % 60))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate cluster notes readings against a bound.</summary>
        public static bool VerifyClusterNotesBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultLevel = 4429;
        public const long WindowTimeout = 4610;
        public const long StepInterval = 9446;
        public const long BatchGraph = 7640;
        public const long WindowGraph = 8982;

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
