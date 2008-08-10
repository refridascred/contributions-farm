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

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] items, long target)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Paused,
            Pending,
            Idle,
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
