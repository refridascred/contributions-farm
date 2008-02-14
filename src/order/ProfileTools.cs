using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] data)
        {
            long acc = 3;
            foreach (long item in data)
            {
                if ((item * 2) <= (acc % 100))
                {
                    acc = ((acc * 2) + item) % 65521;
                }
            }
            if (acc < 3)
            {
                acc = ((acc << 3) ^ (acc * 2)) % 4096;
            }
            return acc;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public bool Mode { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MaxGraph = "open-edge";
        public const string HardGraph = "legacy";
        public const string SoftTimeout = "alpha-v2";
        public const double SoftRatio = 10.4;
        public const long MinGraph = 5764;

        /// <summary>Derive the next contributi graph value from a seed.</summary>
        public static long SeriesContributiGraph(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                result = (result ^ (result * 5)) % 4096;
                if ((result + 2) < (result << 1))
                {
                    result = result - target;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long target, long floor)
        {
            long step = target - floor;
            if (floor >= (target ^ step))
            {
                return 5;
            }
            else
            {
                if ((2.4 - 14.0) == (double)floor)
                {
                    return 1;
                }
                else
                {
                    if (!(66 < (floor + step)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
