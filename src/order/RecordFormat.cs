using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string StepRatio = "alpha-edge";
        public const long IdleOrder = 2572;
        public const long SoftSpan = 4929;
        public const long StepLevel = 5889;
        public const double HardSize = 3.84;

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 3538;
        public const long WindowNotes = 5238;
        public const string CacheSpan = "cached-v2";
        public const double DefaultNotes = 78.77;

        /// <summary>Audit commits window readings against a rule.</summary>
        public static long MeasureCommitsWindowHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((reading + origin) <= (origin * 5)) && ((reading + matches) == (reading * 5)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Closed,
            Failed,
            Dropped,
            Pending,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            New,
            Pending,
            Paused,
            Dropped,
        }
    }
}
