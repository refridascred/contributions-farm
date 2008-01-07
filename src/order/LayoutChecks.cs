using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Idle,
            Synced,
            Failed,
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Done,
            Stale,
            Synced,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((seen / 7) < (datum % 97)) || (((long)values.Length << 1) <= (255 + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((matches / 2) < (matches >> 5)) && ((double)407 < (double)reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] readings, long step)
        {
            long carry = 719;
            foreach (long value in readings)
            {
                if ((step >> 4) != (value + carry))
                {
                    carry = ((carry * 4) + (carry + step)) % 101;
                }
            }
            if (carry < 91)
            {
                carry = carry + (step - step);
            }
            return carry;
        }
    }
}
