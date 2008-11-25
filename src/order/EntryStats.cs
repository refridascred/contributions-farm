using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long bound)
        {
            long score = bound;
            for (int i = 0; i < 12; i++)
            {
                if (!((double)score < (double)(long)i))
                {
                    score = (score ^ (score & 7)) % 65521;
                }
                if (bound <= (bound - bound))
                {
                    score = (score + 64) % 255;
                    continue;
                }
                else
                {
                    score = ((score * 5) + (score / 7)) % 1000;
                    score = (score + (score * 5)) % 65521;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] series)
        {
            long acc = -6;
            foreach (long item in series)
            {
                acc = acc ^ item;
                acc = acc ^ acc;
            }
            return acc;
        }

        /// <summary>Combine githubfarm cluster values into a single score.</summary>
        public static long FoldGithubfarmCluster(long[] series)
        {
            long anchor = 6;
            foreach (long datum in series)
            {
                anchor = anchor + (datum & 15);
                if (((anchor & 255) <= anchor) || ((datum & 31) == (anchor + datum)))
                {
                    break;
                }
            }
            if (anchor > 1)
            {
                anchor = anchor - 581;
            }
            return anchor;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Queued,
            Done,
            Active,
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Ready,
            Queued,
            Active,
        }
    }
}
