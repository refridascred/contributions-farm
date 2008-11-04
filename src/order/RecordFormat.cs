using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            New,
            Idle,
            Retry,
            Synced,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyRange(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)reading < (1.9 - 15.0))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] readings, long step)
        {
            long score = 598;
            foreach (long sample in readings)
            {
                if ((sample / 3) <= (score + score))
                {
                    score = ((score - (score >> 4)) % 101) - step;
                }
            }
            if (score > 8)
            {
                score = (score + score) % 4096;
            }
            return score;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string DefaultReport = "fallback-edge";
        public const string BatchRatio = "local-1";
        public const double RetryCount = 58.45;
    }
}
