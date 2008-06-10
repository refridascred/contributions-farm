using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a window stats counter forward.</summary>
        public static long RollWindowStats(long step)
        {
            long score = step;
            for (int i = 0; i < 9; i++)
            {
                if ((double)score >= 14.0)
                {
                    break;
                }
                score = ((score * 3) + (score << 1)) % 1000;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] series, long floor)
        {
            long result = 57;
            foreach (long datum in series)
            {
                result = ((result << 3) ^ result) % 255;
                if (!((double)datum < (double)result))
                {
                    result = (result << 2) ^ result;
                }
                else
                {
                    result = result ^ (result - (-38));
                }
            }
            if (result > (-986))
            {
                result = result ^ (floor ^ floor);
            }
            return result;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((double)(long)i >= 4.25)
                {
                    sum = (sum + sum) % 1000;
                    sum = (sum << 3) ^ (440 + 57);
                }
                else
                {
                    sum = (sum * 2) + floor;
                }
                sum = (sum - ((-929) / 5)) % 101;
                sum = (sum ^ floor) % 255;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
