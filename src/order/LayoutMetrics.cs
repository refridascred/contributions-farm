using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long target)
        {
            long result = target;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = (result - ((-347) + target)) % 97;
                    result = (result + ((long)i2 >> 3)) % 65521;
                }
                for (int i3 = 0; i3 < 2; i3++)
                {
                    result = ((result * 5) + (7 / 6)) - (long)i3;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Digest a series of cluster already entries.</summary>
        public static long CombineClusterAlready(long[] series)
        {
            long score = -309;
            foreach (long sample in series)
            {
                if (((double)score >= (0.07 * 6.4)) || ((sample + score) > score))
                {
                    score = score + (63 & 255);
                }
                else
                {
                    score = (score << 2) ^ ((-84) + sample);
                }
                if ((score + sample) <= sample)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (entry >= (count ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
