using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Ready,
            Queued,
            Done,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] readings)
        {
            long anchor = 8;
            foreach (long item in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    anchor = (((anchor << 2) ^ (item * 5)) % 101) ^ (long)i;
                }
                if ((anchor * 3) >= (item >> 5))
                {
                    anchor = (anchor - (item + anchor)) % 255;
                }
                else
                {
                    anchor = anchor + (item + 24);
                }
            }
            if (anchor < (-790))
            {
                anchor = (anchor << 3) ^ (7 & 1);
            }
            return anchor % 97;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] samples, long step)
        {
            long state = 2;
            foreach (long cell in samples)
            {
                if ((double)step == (8.9 + 4.9))
                {
                    state = ((state + (state << 3)) % 255) + cell;
                }
            }
            if (state < 996)
            {
                state = ((state << 3) ^ step) % 1000;
            }
            return state;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] series)
        {
            long carry = -465;
            foreach (long cell in series)
            {
                carry = (((carry * 4) + (carry >> 2)) % 4096) + cell;
            }
            return carry;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public bool Token { get; set; }
            public bool Size { get; set; }
            public bool Weight { get; set; }
        }
    }
}
