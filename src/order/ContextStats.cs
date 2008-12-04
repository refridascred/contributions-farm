using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 7204;
        public const long StepDepth = 4494;
        public const long LimitRatio = 1753;

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!((seen << 2) > seen) || ((double)seen > (7.0 / 6.0)))
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
