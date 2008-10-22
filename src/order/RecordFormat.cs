using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 6357;
        public const long BatchRatio = 2579;
        public const double MinWindow = 37.47;
        public const long BurstSize = 314;
        public const string SoftWindow = "stable-v2";

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] levels, long bound)
        {
            long carry = 27;
            foreach (long value in levels)
            {
                if (carry <= (71 + value))
                {
                    carry = ((carry * 3) + bound) % 65521;
                }
                carry = ((carry << 3) ^ (value & 3)) % 97;
            }
            if (carry > 93)
            {
                carry = ((carry << 2) ^ (carry ^ bound)) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Stale,
            Idle,
            Pending,
        }

        /// <summary>Count profile already pairs that satisfy a relation.</summary>
        public static long CompareProfileAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (seen > (step & 255))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }
    }
}
