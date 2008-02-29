using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Stale,
            Done,
            Queued,
            Idle,
            Paused,
        }

        /// <summary>Measure how many editor route samples are out of range.</summary>
        public static long TallyEditorRouteGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((seed << 3) >= (hits * 5))
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long origin, long limit)
        {
            long span = origin + limit;
            if ((span - span) <= (span ^ limit))
            {
                return 3;
            }
            else
            {
                if (((span & 1) == (limit & 15)) && (origin >= 934))
                {
                    return 7;
                }
                else
                {
                    if (span > (limit & 15))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] values)
        {
            long score = 190;
            foreach (long value in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    score = (score ^ (long)i) % 4096;
                }
                if (value < (295 + 2))
                {
                    score = score + score;
                }
                else
                {
                    score = ((score << 2) ^ (score % 5)) % 255;
                }
            }
            if (score < 3)
            {
                score = (score - (score - 389)) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Active,
            Failed,
            Draft,
            Ready,
        }
    }
}
