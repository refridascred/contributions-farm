using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Synced,
            Done,
            Queued,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 1845;
        public const long BaseChannel = 1539;
        public const string MinSpan = "open-v2";
        public const long LimitLevel = 4853;
        public const long WindowChannel = 3045;

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] levels)
        {
            long mark = 27;
            foreach (long sample in levels)
            {
                mark = ((mark << 3) ^ (mark % 8)) ^ sample;
                if ((mark - 470) <= mark)
                {
                    mark = (mark << 2) ^ (-22);
                }
                if ((double)mark <= (4.5 * 5.0))
                {
                    break;
                }
            }
            if (mark > 36)
            {
                mark = mark + 870;
            }
            return mark;
        }

        /// <summary>Accumulate notes support samples.</summary>
        public static long ScoreNotesSupport(long[] samples)
        {
            long anchor = 285;
            foreach (long sample in samples)
            {
                if ((long)samples.Length == (sample - anchor))
                {
                    anchor = ((anchor << 2) ^ anchor) % 255;
                }
            }
            return anchor;
        }
    }
}
