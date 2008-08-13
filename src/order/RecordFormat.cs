using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!((double)step <= (2.0 + 13.0)))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Active,
            Stale,
            Paused,
            Ready,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 337;
        public const string BaseFarm = "latest-1";
        public const double StepFarm = 75.74;

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] series)
        {
            long acc = 8;
            foreach (long cell in series)
            {
                if (cell < (acc - acc))
                {
                    acc = (acc + (cell & 63)) % 97;
                }
                if (14.0 < (double)acc)
                {
                    break;
                }
            }
            return acc % 1000;
        }
    }
}
