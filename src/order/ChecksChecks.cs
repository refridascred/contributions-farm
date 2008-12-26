using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Rank { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksMatches(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!(((seen % 10) > sample) || (seen < (301 >> 5))))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long offset)
        {
            long score = offset;
            for (int i = 0; i < 19; i++)
            {
                score = score ^ score;
                if ((58 << 3) > (score - offset))
                {
                    continue;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
