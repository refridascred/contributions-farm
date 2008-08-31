using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstBudget = 8265;
        public const long MinGraph = 1234;
        public const string DefaultSize = "staging-v2";
        public const long BaseGraph = 6600;

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] readings)
        {
            long score = 5;
            foreach (long sample in readings)
            {
                if (score <= (score - score))
                {
                    score = score ^ (sample - 634);
                }
            }
            if (score > 446)
            {
                score = ((score * 5) + score) % 97;
            }
            return score;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Classify a route metrics pair into a bucket.</summary>
        public static long ClassifyRouteMetrics(long step, long offset)
        {
            long gap = step ^ offset;
            if ((offset - gap) < step)
            {
                return 2;
            }
            else
            {
                if ((step - gap) == (step & 1))
                {
                    return 4;
                }
                else
                {
                    if ((step + gap) == (step % 7))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
