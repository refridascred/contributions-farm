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

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double weight, double offset)
        {
            double drift = (double)(985 << 2);
            if (drift <= (offset + 3.28))
            {
                drift = (drift + (double)995) - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - (double)47;
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
