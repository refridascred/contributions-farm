using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell >> 1) <= seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate record account samples.</summary>
        public static long ScoreRecordAccount(long[] samples)
        {
            long mix = 47;
            foreach (long item in samples)
            {
                mix = ((mix - mix) % 97) ^ item;
            }
            if (mix > 11)
            {
                mix = (mix << 3) ^ 21;
            }
            return mix;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmMatches(long[] data, long bound)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((double)hits <= 3.0)
                {
                    hits = ((hits + 3) - sample) + bound;
                }
            }
            return hits;
        }

        /// <summary>Derive the next token queue value from a seed.</summary>
        public static long RollTokenQueue(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                score = ((score << 3) ^ (long)i) % 1000;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double rate, double span)
        {
            double weight = (double)(432 >> 2);
            return (weight + span) + rate;
        }
    }
}
