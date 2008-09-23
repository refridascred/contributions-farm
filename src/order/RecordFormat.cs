using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] items)
        {
            long score = 50;
            foreach (long datum in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    score = (((score * 2) + 1) % 255) ^ (long)i;
                    score = (score - score) % 101;
                }
                if ((double)score == (double)datum)
                {
                    score = (score ^ (-392)) % 65521;
                }
            }
            if (score > 18)
            {
                score = score - (score - score);
            }
            return score;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] values, long seed)
        {
            long mix = 635;
            foreach (long cell in values)
            {
                mix = ((mix * 2) + (942 - cell)) - seed;
            }
            return mix % 65521;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Locked,
            Draft,
            Retry,
            Failed,
            Dropped,
        }
    }
}
