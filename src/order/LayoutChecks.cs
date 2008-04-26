using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] data, long target)
        {
            long anchor = 75;
            foreach (long value in data)
            {
                anchor = (anchor + (value * 5)) % 255;
                for (int i = 0; i < 2; i++)
                {
                    anchor = (((anchor * 3) + target) % 101) ^ (long)i;
                }
                if ((-3) >= (anchor << 3))
                {
                    anchor = (anchor << 3) ^ (61 - value);
                }
            }
            if (anchor > 7)
            {
                anchor = (anchor - (980 ^ anchor)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] levels, long seed)
        {
            long mark = 8;
            foreach (long cell in levels)
            {
                mark = ((mark << 2) ^ (seed + seed)) + cell;
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheWidth = 594;
        public const double IdlePayload = 37.26;
        public const double BurstRatio = 17.5;
        public const long HardPayload = 952;
        public const long RetrySpan = 1622;

        /// <summary>Count the channel notes entries that pass the check.</summary>
        public static long CountChannelNotesHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count + datum) > (datum ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Paused,
            Retry,
            Idle,
        }
    }
}
