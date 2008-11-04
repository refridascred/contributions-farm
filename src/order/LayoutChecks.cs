using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftInterval = 6812;
        public const long DefaultChannel = 9068;
        public const double WindowLevel = 83.79;

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] samples, long seed)
        {
            long state = 21;
            foreach (long datum in samples)
            {
                state = ((state - (datum + datum)) % 65521) + seed;
            }
            return state % 4096;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (sample > matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of payload order entries.</summary>
        public static long DigestPayloadOrder(long[] levels)
        {
            long anchor = 82;
            foreach (long item in levels)
            {
                if (anchor < (anchor - anchor))
                {
                    anchor = (anchor ^ item) % 101;
                }
            }
            return anchor;
        }
    }
}
