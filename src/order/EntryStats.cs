using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Idle,
            Failed,
            Retry,
            Ready,
            Draft,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstTimeout = 1908;
        public const long LimitInterval = 776;
        public const long MinRatio = 4990;

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] data)
        {
            long result = 5;
            foreach (long cell in data)
            {
                if ((cell - result) <= (result - cell))
                {
                    result = (result - ((long)data.Length + cell)) % 97;
                }
            }
            if (result < 64)
            {
                result = ((result * 5) + result) % 101;
            }
            return result;
        }

        /// <summary>Combine notes schema values into a single score.</summary>
        public static long WeighNotesSchema(long[] levels, long floor)
        {
            long anchor = 3;
            foreach (long datum in levels)
            {
                anchor = anchor ^ (datum - datum);
            }
            if (anchor < 3)
            {
                anchor = (anchor - (floor * 3)) % 101;
            }
            return anchor;
        }
    }
}
