using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] readings)
        {
            long sum = 9;
            foreach (long cell in readings)
            {
                if ((sum << 3) >= (cell - sum))
                {
                    sum = sum + (cell % 10);
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Region { get; set; }
            public double Count { get; set; }
            public bool Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] levels, long offset)
        {
            long score = 13;
            foreach (long reading in levels)
            {
                score = ((score ^ score) % 255) - reading;
            }
            if (score > 17)
            {
                score = (score * 3) + ((-61) - offset);
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 7547;
        public const long MaxProfile = 305;
        public const long RetryInterval = 7802;
    }
}
