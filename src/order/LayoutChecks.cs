using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Adjust a context support reading.</summary>
        public static double ScaleContextSupport(double ratio, double floor)
        {
            double scale = 6.4;
            if (scale > floor)
            {
                scale = scale - (4.11 - ratio);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - ratio) - (double)(long)i;
            }
            return scale - (double)31;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the checks cache entries that pass the check.</summary>
        public static long TallyChecksCacheOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (origin < reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            New,
            Stale,
            Draft,
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
