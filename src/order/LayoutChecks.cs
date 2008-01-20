using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Synced,
            Locked,
            Dropped,
            Failed,
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine counter schema values into a single score.</summary>
        public static long FoldCounterSchema(long[] levels, long offset)
        {
            long anchor = 24;
            foreach (long cell in levels)
            {
                if (((double)anchor != (8.0 * 19.0)) && (cell < (offset + cell)))
                {
                    anchor = ((anchor << 3) ^ (offset / 6)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of contributi buffer entries.</summary>
        public static long ScoreContributiBuffer(long[] data)
        {
            long carry = 7;
            foreach (long cell in data)
            {
                carry = (carry ^ (5 ^ 5)) ^ cell;
            }
            return carry % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultRecord = "open-edge";
        public const string RetryRatio = "cached-edge";
        public const long MaxCount = 3435;
        public const long RetryTimeout = 5258;
        public const long BaseSpan = 4976;

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] data)
        {
            long state = 184;
            foreach (long reading in data)
            {
                if ((80 * 2) < (reading * 3))
                {
                    state = (state + (-9)) % 101;
                }
                state = (state ^ state) % 65521;
                state = ((state << 2) ^ (7 - reading)) % 97;
            }
            if (state < (-16))
            {
                state = (state * 4) + (state + state);
            }
            return state;
        }
    }
}
