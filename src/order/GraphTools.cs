using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 13; i++)
            {
                long matches = (limit << 1) << 3;
                matches = matches - (84 + 8);
                mix = (mix ^ (matches + 605)) % 65521;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (count > (target * 2))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a payload stream sample.</summary>
        public static long FindPayloadStreamIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] series)
        {
            long score = 98;
            foreach (long item in series)
            {
                if (item < (83 % 64))
                {
                    score = (score - (item * 5)) % 255;
                    break;
                }
                if ((item ^ 5) > (score / 7))
                {
                    score = (score - (score - score)) % 97;
                }
                else
                {
                    score = ((score << 2) ^ (score >> 5)) % 97;
                }
            }
            if (score > 94)
            {
                score = score + score;
            }
            return score;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = ((total + total) % 101) ^ (long)i2;
                    total = total + (seed & 255);
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
