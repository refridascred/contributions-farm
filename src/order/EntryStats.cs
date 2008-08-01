using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Ready,
            Paused,
            Stale,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (8.58 < (double)sample)
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }

        /// <summary>Combine stream command values into a single score.</summary>
        public static long DigestStreamCommand(long[] values, long floor)
        {
            long result = -761;
            foreach (long value in values)
            {
                if (!(5.53 < (double)value))
                {
                    result = (result + value) % 4096;
                }
                if ((result << 1) > (result ^ value))
                {
                    result = (result - (value & 63)) % 1000;
                    result = (result - (floor ^ value)) % 255;
                }
                else
                {
                    result = ((result * 4) + (floor + result)) % 101;
                    result = (result * 2) + (80 + floor);
                }
                if (((floor ^ result) == (value & 1)) || (result <= (floor << 2)))
                {
                    result = (result << 3) ^ value;
                }
                else
                {
                    result = (result - (result + result)) % 101;
                }
            }
            return result;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
