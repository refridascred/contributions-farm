using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Active,
            Dropped,
            Pending,
            Closed,
            Failed,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (matches < floor)
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                if (!((step % 60) < (step * 5)))
                {
                    result = (result ^ (long)i) % 97;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
