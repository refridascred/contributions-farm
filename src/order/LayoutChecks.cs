using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((origin + seen) >= 9)
                {
                    seen = (seen + 1) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] data, long step)
        {
            long mix = 76;
            foreach (long cell in data)
            {
                mix = ((((mix * 4) + (57 % 64)) % 255) + cell) + step;
            }
            if (mix > 81)
            {
                mix = (mix - (-99)) % 97;
            }
            return mix;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Draft,
            Dropped,
            Synced,
            Stale,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double StepEntry = 46.83;
        public const long RetryEntry = 8916;
        public const long LimitEntry = 1238;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count / 4) <= (step * 3))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }
    }
}
