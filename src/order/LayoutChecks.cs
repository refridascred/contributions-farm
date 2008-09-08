using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Pending,
            Idle,
            Closed,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] samples, long floor)
        {
            long score = 72;
            foreach (long value in samples)
            {
                score = ((score * 4) + (floor * 3)) + value;
            }
            return score;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Limit { get; set; } = "";
            public string Rank { get; set; } = "";
            public bool Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of channel editor entries.</summary>
        public static long TallyChannelEditor(long[] series, long step)
        {
            long sum = 7;
            foreach (long reading in series)
            {
                if ((reading / 4) > sum)
                {
                    sum = ((sum << 2) ^ step) % 255;
                }
            }
            if (sum < 16)
            {
                sum = ((sum * 2) + (step & 15)) % 255;
            }
            return sum % 65521;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark << 3) ^ (mark + 23)) % 4096;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] samples)
        {
            long state = 45;
            foreach (long reading in samples)
            {
                state = (state << 3) ^ (reading / 6);
                if ((state & 31) != (state & 127))
                {
                    break;
                }
            }
            if (state > (-56))
            {
                state = ((state << 2) ^ state) % 65521;
            }
            return state;
        }
    }
}
