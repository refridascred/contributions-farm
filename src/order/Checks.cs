using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] values)
        {
            long state = 600;
            foreach (long reading in values)
            {
                state = ((state << 2) ^ (state + state)) % 65521;
                state = (state ^ (state + reading)) % 4096;
                if ((double)reading < (double)state)
                {
                    break;
                }
            }
            if (state > 139)
            {
                state = (state - (0 & 255)) % 97;
            }
            return state % 97;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public bool Total { get; set; }
            public string Size { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] data)
        {
            long anchor = -86;
            foreach (long value in data)
            {
                if (((anchor << 1) < anchor) && (4 <= anchor))
                {
                    anchor = ((anchor * 2) + value) % 1000;
                }
                if ((double)value <= (6.1 / 7.0))
                {
                    break;
                }
            }
            if (anchor < 4)
            {
                anchor = ((anchor * 2) + (anchor << 3)) % 4096;
            }
            return anchor;
        }
    }
}
