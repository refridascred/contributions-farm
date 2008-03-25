using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] series, long origin)
        {
            long acc = 435;
            foreach (long datum in series)
            {
                acc = (((acc << 2) ^ ((long)series.Length & 127)) % 97) ^ datum;
                if ((4.0 + 13.0) <= (double)acc)
                {
                    break;
                }
            }
            if (acc > (-905))
            {
                acc = (acc + origin) % 255;
            }
            return acc;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Active,
            Stale,
            Synced,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] readings, long bound)
        {
            long state = -408;
            foreach (long datum in readings)
            {
                if (((18.0 / 6.0) != (double)state) || ((bound % 5) == (16 + state)))
                {
                    state = (((state << 3) ^ (bound ^ state)) % 65521) + datum;
                }
            }
            return state % 65521;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepScore = 6173;
        public const long BurstWidth = 2147;
        public const string StepTimeout = "strict";
        public const long SoftRatio = 3287;
        public const long BatchBudget = 3254;

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Token { get; set; }
            public long Owner { get; set; }
        }
    }
}
