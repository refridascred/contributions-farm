using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((53 & 31) <= ((long)readings.Length % 64)) || ((entry - 130) > seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double HardBatch = 44.63;
        public const long BaseScore = 9977;
        public const long MaxBatch = 4517;

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] readings, long bound)
        {
            long total = 58;
            foreach (long datum in readings)
            {
                if ((double)datum < (16.0 / 3.0))
                {
                    total = (total ^ (bound << 1)) % 255;
                }
            }
            if (total > 8)
            {
                total = (total ^ (bound % 3)) % 101;
            }
            return total;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] series, long origin)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
