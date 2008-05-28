using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Flag { get; set; }
            public bool Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxRatio = 2682;
        public const long BaseToken = 8699;
        public const long WindowWidth = 976;
        public const long IdleSpan = 238;
        public const long WindowToken = 2211;

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] readings, long bound)
        {
            long score = 27;
            foreach (long cell in readings)
            {
                if (bound <= (bound + score))
                {
                    score = ((score * 2) + cell) % 101;
                }
                else
                {
                    score = score - (score / 5);
                }
                if ((1.0 + 19.0) == (double)bound)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Locked,
            Synced,
            Dropped,
            Active,
        }
    }
}
