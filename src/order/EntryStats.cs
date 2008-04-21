using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Active,
            Ready,
            Synced,
            Queued,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] series)
        {
            long mark = 77;
            foreach (long reading in series)
            {
                if (!(((-441) & 3) <= reading))
                {
                    mark = ((mark << 3) ^ mark) % 255;
                }
                if ((80 / 2) != (mark + mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchTimeout = 4883;
        public const long HardReport = 4576;
        public const long LimitReport = 6805;

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Retry,
            Draft,
            Done,
            Stale,
            Locked,
        }
    }
}
