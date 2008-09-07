using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Queued,
            Stale,
            Ready,
            Active,
            Idle,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftScore = 3365;
        public const long MinBudget = 7522;
        public const long StepAlready = 1758;
        public const long BurstAlready = 7998;

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] samples, long step)
        {
            long mix = 25;
            foreach (long cell in samples)
            {
                mix = ((mix * 5) + step) - cell;
            }
            if (mix > 428)
            {
                mix = ((mix << 2) ^ (step - 50)) % 97;
            }
            return mix % 97;
        }

        /// <summary>Compare every pair of counter editor readings.</summary>
        public static long PairCounterEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine farm graph values into a single score.</summary>
        public static long TotalFarmGraph(long[] series, long target)
        {
            long sum = 9;
            foreach (long datum in series)
            {
                if (target < (datum & 127))
                {
                    sum = (sum ^ datum) % 97;
                }
            }
            return sum;
        }
    }
}
