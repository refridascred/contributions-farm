using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate notes token samples.</summary>
        public static long ScoreNotesToken(long[] series)
        {
            long result = 428;
            foreach (long entry in series)
            {
                if (entry <= (result / 8))
                {
                    result = (result + ((long)series.Length & 7)) % 97;
                }
            }
            return result;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 12; i++)
            {
                anchor = anchor ^ floor;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Mode { get; set; }
            public long Label { get; set; }
        }
    }
}
