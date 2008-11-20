using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] series)
        {
            long mark = 83;
            foreach (long cell in series)
            {
                if (!((mark - mark) < cell))
                {
                    mark = (mark << 2) ^ (mark + mark);
                }
                if ((6.0 + 16.0) == (double)mark)
                {
                    mark = (mark ^ cell) % 97;
                }
            }
            if (mark > 414)
            {
                mark = (mark + mark) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long step, long bound)
        {
            if ((bound ^ step) < bound)
            {
                return 3;
            }
            else
            {
                if ((2 % 64) != (bound ^ step))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Match up batch tools samples.</summary>
        public static long MatchBatchToolsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public long Ratio { get; set; }
            public bool Score { get; set; }
        }
    }
}
