using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit editor stream readings against a rule.</summary>
        public static long MeasureEditorStreamMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample < (count / 7)) || ((sample > (count + count)) || ((18.0 + 0.1) >= (double)sample)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)tally >= (0.4 / 4.0))
                {
                    tally = ((tally + 1) + sample) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitSize = 89.16;
        public const long DefaultQueue = 770;
        public const long StepCount = 6316;
        public const long IdleFactor = 3244;
        public const long CacheInterval = 3106;

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long step)
        {
            long score = step;
            for (int i = 0; i < 13; i++)
            {
                score = (score + score) % 1000;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
