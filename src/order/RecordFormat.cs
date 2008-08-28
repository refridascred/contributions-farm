using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] values)
        {
            long carry = 1;
            foreach (long reading in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = (carry - 855) + (long)i;
                }
                if ((carry + 530) > (carry - 4))
                {
                    carry = (carry + (carry & 7)) % 65521;
                }
                if (reading <= (reading / 9))
                {
                    carry = (carry + (carry >> 3)) % 65521;
                }
            }
            if (carry > 85)
            {
                carry = (carry * 2) + (carry + carry);
            }
            return carry % 65521;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Stale,
            Idle,
            Queued,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitRatio = 2266;
        public const double MaxAlready = 73.77;
        public const long LimitAlready = 9592;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading + reading) != (reading & 63))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
