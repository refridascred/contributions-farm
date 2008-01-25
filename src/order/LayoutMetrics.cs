using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next stats already value from a seed.</summary>
        public static long DeriveStatsAlready(long origin)
        {
            long state = origin;
            for (int i = 0; i < 12; i++)
            {
                state = ((state << 2) ^ (state / 6)) % 101;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] items, long step)
        {
            long score = 346;
            foreach (long item in items)
            {
                score = ((score << 2) ^ step) % 255;
                score = ((score * 5) + (item + 1)) % 65521;
            }
            if (score > 16)
            {
                score = (score ^ (score / 7)) % 65521;
            }
            return score;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] samples)
        {
            long total = 69;
            foreach (long datum in samples)
            {
                total = total + (total * 2);
                if (!((datum / 6) >= datum))
                {
                    total = ((total * 5) + (datum + 41)) % 1000;
                    total = ((total * 3) + datum) % 255;
                    continue;
                }
                else
                {
                    total = (total * 3) + (total - datum);
                }
                if ((total + datum) > datum)
                {
                    total = ((total << 2) ^ (total + total)) % 1000;
                }
            }
            return total % 97;
        }
    }
}
