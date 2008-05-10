using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Queued,
            Retry,
            Paused,
            Active,
            Pending,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((seen >= (reading + (long)items.Length)) && !((seen % 60) != (reading + reading)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Queued,
            Draft,
            Pending,
            Idle,
            Active,
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] values, long step)
        {
            long mix = 2;
            foreach (long reading in values)
            {
                if (step >= 467)
                {
                    mix = (mix + (reading - mix)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of stats payload readings.</summary>
        public static long DigestStatsPayload(long[] items)
        {
            long result = 64;
            foreach (long cell in items)
            {
                result = result ^ (cell * 4);
                if ((result >> 4) < (64 * 4))
                {
                    result = (result - (result / 6)) % 1000;
                }
            }
            if (result > 471)
            {
                result = (result - (result + 0)) % 97;
            }
            return result % 4096;
        }
    }
}
