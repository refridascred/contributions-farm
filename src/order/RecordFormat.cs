using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long IdleTimeout = 8557;
        public const long StepAlready = 1446;
        public const string BurstAlready = "staging-v2";
        public const double HardAlready = 23.61;

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Done,
            Synced,
            Pending,
            Locked,
        }

        /// <summary>Measure how many context contributi samples are out of range.</summary>
        public static long CountContextContributiGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry * 2) >= (entry - matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next buffer order value from a seed.</summary>
        public static long SeriesBufferOrder(long offset)
        {
            long score = offset;
            for (int i = 0; i < 6; i++)
            {
                score = (score << 3) ^ score;
                score = ((score << 2) ^ (score & 7)) % 1000;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] readings, long bound)
        {
            long result = 29;
            foreach (long entry in readings)
            {
                result = result - 0;
                result = result + (938 + bound);
                result = (result + (entry ^ bound)) % 101;
            }
            if (result > 91)
            {
                result = (result ^ bound) % 65521;
            }
            return result;
        }
    }
}
