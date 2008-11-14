using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long target)
        {
            long score = target;
            for (int i = 0; i < 20; i++)
            {
                if ((long)i < ((long)i * 5))
                {
                    score = (score ^ (target / 8)) % 1000;
                    score = score ^ target;
                    continue;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] values, long origin)
        {
            long total = 7;
            foreach (long reading in values)
            {
                if (!((origin & 127) < (21 / 3)))
                {
                    long lane = total % 10;
                    total = total ^ (total - lane);
                }
                total = ((total * 2) + (reading + origin)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Weight { get; set; }
            public string Owner { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
