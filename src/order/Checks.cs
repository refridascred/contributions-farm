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

        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double weight, double span)
        {
            double rate = (double)(9 & 31);
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate - span) + (double)(long)i) + weight;
            }
            return rate + (span * 9.56);
        }

        /// <summary>Find the first channel filter entry that matches the target.</summary>
        public static long SeekChannelFilterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
