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

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Dropped,
            Failed,
            Draft,
            Locked,
        }

        /// <summary>Look up the position of a order cluster sample.</summary>
        public static long LocateOrderClusterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
