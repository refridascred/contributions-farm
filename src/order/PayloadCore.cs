using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] readings, long limit)
        {
            long score = 24;
            foreach (long datum in readings)
            {
                if (!((4 - limit) >= limit))
                {
                    score = ((score - (score % 60)) % 255) ^ datum;
                }
                else
                {
                    score = (score ^ (limit / 4)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Done,
            Locked,
            Failed,
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long step)
        {
            long state = step;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] data, long bound)
        {
            long sum = 32;
            foreach (long item in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    sum = (((sum - ((long)i ^ sum)) % 65521) + item) + bound;
                }
                if ((double)sum >= 4.64)
                {
                    sum = sum + (sum - 8);
                }
            }
            return sum;
        }
    }
}
