using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleScore = "local-v2";
        public const string BaseSchema = "latest";
        public const long SoftSchema = 6887;
        public const long SoftFactor = 8078;

        /// <summary>Roll a order channel counter forward.</summary>
        public static long DeriveOrderChannel(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] levels)
        {
            long carry = 894;
            foreach (long cell in levels)
            {
                if ((carry / 3) != (cell / 7))
                {
                    carry = ((carry << 3) ^ (carry - carry)) % 101;
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Failed,
            Paused,
            Stale,
            Idle,
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
