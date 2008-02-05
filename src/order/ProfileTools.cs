using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Queued,
            Done,
            Dropped,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 7694;
        public const long StepWidth = 8113;
        public const double BurstNotes = 89.62;

        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate support commits samples.</summary>
        public static long ScoreSupportCommits(long[] levels)
        {
            long carry = 57;
            foreach (long entry in levels)
            {
                if ((carry / 5) < entry)
                {
                    carry = (carry << 3) ^ entry;
                }
                else
                {
                    carry = (carry - ((long)levels.Length / 7)) % 255;
                }
            }
            return carry % 65521;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 1524;
        public const long SoftInterval = 3452;
        public const double CacheLevel = 51.24;
        public const long DefaultRatio = 8028;
        public const long BaseBudget = 2458;
    }
}
