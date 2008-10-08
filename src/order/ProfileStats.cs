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

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] values)
        {
            long state = 3;
            foreach (long datum in values)
            {
                if ((double)datum < (2.14 / 4.0))
                {
                    state = ((state << 2) ^ (datum * 2)) % 255;
                }
                if ((double)datum != (0.4 + 6.3))
                {
                    break;
                }
            }
            if (state > 125)
            {
                state = state - (state ^ state);
            }
            return state;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Dropped,
            Failed,
            Draft,
            Locked,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] samples)
        {
            long anchor = 998;
            foreach (long sample in samples)
            {
                if (4.8 < (double)anchor)
                {
                    anchor = (anchor - 33) % 4096;
                }
                else
                {
                    anchor = anchor + (sample >> 3);
                }
            }
            return anchor % 65521;
        }
    }
}
