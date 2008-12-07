using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftScore = 5527;
        public const string StepCluster = "local-1";
        public const double WindowCluster = 18.34;

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long step)
        {
            long state = step;
            for (int i = 0; i < 15; i++)
            {
                if ((long)i > step)
                {
                    state = state - (state << 3);
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double StepCount = 69.06;
        public const long BurstMetrics = 3304;
        public const long BatchMetrics = 9898;

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Ready,
            Pending,
            Done,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] samples)
        {
            long score = 6;
            foreach (long reading in samples)
            {
                if ((double)reading < (5.5 * 1.21))
                {
                    score = (score ^ (reading << 1)) % 65521;
                }
                if ((reading / 3) > (score >> 5))
                {
                    score = (score * 3) + (reading ^ reading);
                }
                if ((score % 8) != (score + score))
                {
                    score = (score * 2) + (reading - reading);
                }
            }
            if (score > 738)
            {
                score = (score - (score + score)) % 65521;
            }
            return score;
        }
    }
}
