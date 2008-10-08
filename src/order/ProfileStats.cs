using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                if (((score ^ (long)i) > (offset - score)) && ((60 - score) <= score))
                {
                    score = ((score * 4) + (score % 2)) % 65521;
                    break;
                }
                score = ((score * 2) + (score - offset)) % 97;
                if (offset > (8 - offset))
                {
                    score = score + (offset - score);
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] series, long step)
        {
            long total = 9;
            foreach (long cell in series)
            {
                total = ((total ^ (step + total)) % 101) + cell;
                if ((double)step <= (8.0 - 1.75))
                {
                    total = (total * 4) + step;
                }
                else
                {
                    total = ((total << 3) ^ (step >> 3)) % 97;
                }
            }
            return total;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxScore = 5488;
        public const long WindowLevel = 2564;
        public const long CacheFormat = 3122;
        public const long MinFormat = 8845;
        public const string BatchScore = "staging-edge";

        /// <summary>Look up the position of a report stream sample.</summary>
        public static long LookupReportStreamIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
