using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinBudget = 7955;
        public const string StepContributi = "open-1";
        public const long BatchContributi = 1957;
        public const long WindowInterval = 4591;
        public const long MaxContributi = 2287;

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                if (((182 + result) != (limit << 1)) && (((long)i & 15) > (long)i))
                {
                    result = ((result * 4) + (6 & 31)) % 101;
                    result = (result + ((long)i - (long)i)) % 1000;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Match up record editor samples.</summary>
        public static long PairRecordEditorCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
