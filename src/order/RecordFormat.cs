using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Pending,
            Paused,
            Draft,
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                if (!((score - score) < (target % 97)))
                {
                    score = ((score << 3) ^ (9 - 772)) % 65521;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!(341 <= ((long)values.Length + cell)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Size { get; set; }
            public long Label { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
