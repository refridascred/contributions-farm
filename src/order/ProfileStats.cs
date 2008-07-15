using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count already metric pairs that satisfy a relation.</summary>
        public static long CompareAlreadyMetricCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Idle,
            Synced,
            Stale,
        }

        /// <summary>Fold a list of report filter readings.</summary>
        public static long DigestReportFilter(long[] values)
        {
            long mix = 94;
            foreach (long value in values)
            {
                if (((value - mix) < value) && ((mix & 31) <= mix))
                {
                    mix = (mix + (mix % 10)) % 65521;
                }
                if (20.0 < (double)value)
                {
                    mix = mix - (981 * 5);
                }
            }
            return mix;
        }
    }
}
